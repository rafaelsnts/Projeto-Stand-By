using SistemaOS.Banco_Global;
using SistemaOS.Clientes;
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

namespace SistemaOS.Financeiro
{
    public partial class form_Estatisticas : Form
    {
        private form_ServicoAndamento form_ServicosAndamento;
        private form_ServicoConcluido form_ServicosConcluido;
        private List<IGrouping<int, ServicosAdamentoEstrutura>> topClienteComMaisServicos;

        public form_Estatisticas(form_ServicoConcluido _servicosConcluido)
        {
            InitializeComponent();
            InicializarBancoGlobal();
            CarregarTabelaFinanceiro();
            form_ServicosConcluido = _servicosConcluido;
        }

        public form_Estatisticas(form_ServicoAndamento _servicosAndamento)
        {
            InitializeComponent();
            InicializarBancoGlobal();
            BuscarClientesComMaisServicos();
            CarregarTabelaFinanceiro();
            form_ServicosAndamento = _servicosAndamento;
        }

        public form_Estatisticas()
        {
            InitializeComponent();
            InicializarBancoGlobal();
            BuscarClientesComMaisServicos();
            CarregarTabelaFinanceiro();
        }

        private void InicializarBancoGlobal()
        {
            BancoGlobalStatico.CarregarClientes();
            BancoGlobalStatico.CarregarServicosAndamento();
        }

        private void BuscarClientesComMaisServicos()
        {
            topClienteComMaisServicos = BancoGlobalStatico.listBancoServicosAndamento
                .Where(clienteWhere => clienteWhere.sv_Status == 0)
                .GroupBy(cliente => cliente.sv_fk_cl_idCliente)
                .OrderByDescending(clienteOrdem => clienteOrdem.Count()).ToList();

            foreach (var cliente in topClienteComMaisServicos)
            {
                PegarClientesMaiorQtdServico(cliente.Key);
            }
        }

        private int AgruparClientesServico(int _idCliente)
        {
            int qtdServicos = 0;
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                if (cliente.cl_Id == _idCliente)
                {
                    qtdServicos++;
                }
            }
            return qtdServicos;
        }

        private int PegarClientesMaiorQtdServico(int _idCliente)
        {
            int qtdServicos = 0;
            foreach (ServicosAdamentoEstrutura servico in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (servico.sv_fk_cl_idCliente == _idCliente)
                {
                    qtdServicos++;
                }
            }
            return qtdServicos;
        }

        private void CarregarTabelaFinanceiro()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("QTD SERVIÇO");

            foreach (var servico in topClienteComMaisServicos)
            {
                int qtdServicos = PegarClientesMaiorQtdServico(servico.Key);
                dt.Rows.Add(BuscarNomeCliente(servico.Key), qtdServicos);
            }
            grid_FinanceiroCliente.DataSource = dt;
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
    }
}