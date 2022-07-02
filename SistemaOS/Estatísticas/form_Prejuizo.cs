using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaOS.Serviços_Concluidos;
using SistemaOS.Serviços_em_Andamento;
using SistemaOS.Banco_Global;
using SistemaOS.Clientes;

namespace SistemaOS.Financeiro
{
    public partial class form_Prejuizo : Form
    {
        private List<ServicosAdamentoEstrutura> maioresPrejuizos;

        public form_Prejuizo()
        {
            InitializeComponent();
            InicializarBancoGlobal();
        }

        private void InicializarBancoGlobal()
        {
            BancoGlobalStatico.CarregarClientes();
            BancoGlobalStatico.CarregarServicosAndamento();
        }

        private void BuscarMaioresPrejuizos()
        {
            maioresPrejuizos = BancoGlobalStatico.listBancoServicosAndamento
                .Where(servicoWhere => servicoWhere.sv_Status == 0).Where(servicoPrejuizo => servicoPrejuizo.sv_lucroServico < 0)
                .OrderBy(lucroOrdem => lucroOrdem.sv_lucroServico).ToList();
        }

        private void CarregarTabelaLucro()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("PREJUIZO");

            foreach (ServicosAdamentoEstrutura servico in maioresPrejuizos)
            {
                dt.Rows.Add(BuscarNomeCliente(servico.sv_fk_cl_idCliente), servico.sv_lucroServico);
            }
            grid_Prejuizo.DataSource = dt;
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
                    BuscarMaioresPrejuizos();
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