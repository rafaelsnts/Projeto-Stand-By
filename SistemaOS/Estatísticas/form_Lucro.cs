using SistemaOS.Serviços_Concluidos;
using SistemaOS.Serviços_em_Andamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaOS.Banco_Global;
using SistemaOS.Clientes;

namespace SistemaOS.Financeiro
{
    public partial class form_Lucro : Form
    {
        private form_ServicoAndamento form_ServicosAndamento;
        private form_ServicoConcluido form_ServicosConcluido;
        private List<ServicosAdamentoEstrutura> maioresLucros;

        public form_Lucro(form_ServicoAndamento _servicosAndamento)
        {
            InitializeComponent();
            InicializarBancoGlobal();
            form_ServicosAndamento = _servicosAndamento;
            //BuscarMaioresLucros();
            //CarregarTabelaLucro();
        }

        public form_Lucro(form_ServicoConcluido _servicosConcluido)
        {
            InitializeComponent();
            InicializarBancoGlobal();
            form_ServicosConcluido = _servicosConcluido;
            //BuscarMaioresLucros();
            //CarregarTabelaLucro();
        }

        public form_Lucro()
        {
            InitializeComponent();
            InicializarBancoGlobal();
            //BuscarMaioresLucros();
            //CarregarTabelaLucro();
        }

        private void InicializarBancoGlobal()
        {
            BancoGlobalStatico.CarregarClientes();
            BancoGlobalStatico.CarregarServicosAndamento();
        }

        private void BuscarMaioresLucros()
        {
            maioresLucros = BancoGlobalStatico.listBancoServicosAndamento
                .Where(servicoWhere => servicoWhere.sv_Status == 0).Where(servicoLucro => servicoLucro.sv_lucroServico >= 0)
                .OrderByDescending(lucroOrdem => lucroOrdem.sv_lucroServico).ToList();
        }

        private void CarregarTabelaLucro()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("LUCRO");

            foreach (ServicosAdamentoEstrutura servico in maioresLucros)
            {
                dt.Rows.Add(BuscarNomeCliente(servico.sv_fk_cl_idCliente), servico.sv_lucroServico);
            }
            grid_Lucro.DataSource = dt;
        }

        private string BuscarNomeCliente(int _idCliente)
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                if (cliente.cl_Id == _idCliente)
                {
                    return cliente.cl_Nome;
                }
            }
            return "";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            foreach (ServicosAdamentoEstrutura servico in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (date_Final.Value.Date >= date_Inicial.Value.Date && date_Inicial.Value.Date <= date_Final.Value.Date)
                {
                    BuscarMaioresLucros();
                    CarregarTabelaLucro();
                }
                else
                {
                    MessageBox.Show($"Informe uma data válida", "ATENÇÃO");
                }
            }
        }
    }
}