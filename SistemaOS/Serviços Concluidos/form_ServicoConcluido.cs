using SistemaOS.Banco_Global;
using SistemaOS.Clientes;
using SistemaOS.Serviços;
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

namespace SistemaOS.Serviços_Concluidos
{
    public partial class form_ServicoConcluido : Form
    {
        public form_ServicoConcluido()
        {
            InitializeComponent();
            BancoGlobalStatico.CarregarClientes();
            CarregarTabelaServicosConcluidos();
        }

        public string BuscarNomeCliente(int id)
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                if (cliente.sv_Id == id)
                {
                    return cliente.sv_Nome;
                }
            }

            return "";
        }

        public void CarregarTabelaServicosConcluidos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ID CLIENTE");
            dt.Columns.Add("APARELHO");
            dt.Columns.Add("DEFEITO");
            dt.Columns.Add("SENHA");
            dt.Columns.Add("SITUAÇÃO");
            dt.Columns.Add("ACESSORIOS");
            dt.Columns.Add("CADASTRO");
            dt.Columns.Add("CONCLUSÃO");
            dt.Columns.Add("R$ SERVIÇO");
            dt.Columns.Add("R$ PEÇA");
            dt.Columns.Add("R$ LUCRO");
            dt.Columns.Add("SERVIÇO");
            dt.Columns.Add("STATUS");

            foreach (ServicosAdamentoEstrutura servicoConcluido in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (servicoConcluido.sv_Status == 0)
                {
                    dt.Rows.Add(servicoConcluido.sv_Id, BuscarNomeCliente(servicoConcluido.sv_fk_cl_idCliente), servicoConcluido.sv_Aparelho,
                    servicoConcluido.sv_Defeito, servicoConcluido.sv_Senha, servicoConcluido.sv_Situacao,
                    servicoConcluido.sv_Acessorios, servicoConcluido.sv_dataCadastro.ToShortDateString(),
                    servicoConcluido.sv_dataConclusao.ToShortDateString(), string.Format("{0:0.00}", servicoConcluido.sv_valorServico),
                    string.Format("{0:0.00}", servicoConcluido.sv_valorPeca), string.Format("{0:0.00}", servicoConcluido.sv_lucroServico), servicoConcluido.sv_servicoFeito,
                    (servicoConcluido.sv_Status) == 1 ? "Em andamento" : "Concluido");
                }
            }

            grid_ServicoConcluido.DataSource = dt;
        }

        public void CarregarTabelaPorBusca(List<ServicosAdamentoEstrutura> _servicosConcluido)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("ID CLIENTE");
            dt.Columns.Add("APARELHO");
            dt.Columns.Add("DEFEITO");
            dt.Columns.Add("SENHA");
            dt.Columns.Add("SITUAÇÃO");
            dt.Columns.Add("ACESSORIOS");
            dt.Columns.Add("DATA DE CADASTRO");
            dt.Columns.Add("VALOR DO SERVIÇO");
            dt.Columns.Add("DATA DE CONCLUSÃO");
            dt.Columns.Add("VALOR DA PEÇA");
            dt.Columns.Add("LUCRO SERVIÇO");
            dt.Columns.Add("SERVIÇO FEITO");
            dt.Columns.Add("STATUS");

            foreach (ServicosAdamentoEstrutura servicoConcluido in _servicosConcluido)
            {
                if (servicoConcluido.sv_Status == 0)
                {
                    dt.Rows.Add(servicoConcluido.sv_Id, BuscarNomeCliente(servicoConcluido.sv_fk_cl_idCliente), servicoConcluido.sv_Aparelho,
                    servicoConcluido.sv_Defeito, servicoConcluido.sv_Senha, servicoConcluido.sv_Situacao,
                    servicoConcluido.sv_Acessorios, servicoConcluido.sv_dataCadastro.ToShortDateString(),
                    servicoConcluido.sv_dataConclusao.ToShortDateString(), string.Format("{0:0.00}", servicoConcluido.sv_valorServico),
                    string.Format("{0:0.00}", servicoConcluido.sv_valorPeca), string.Format("{0:0.00}", servicoConcluido.sv_lucroServico), servicoConcluido.sv_servicoFeito,
                    (servicoConcluido.sv_Status) == 1 ? "Em andamento" : "Concluido");
                }
            }

            grid_ServicoConcluido.DataSource = dt;
        }

        private void txt_BuscarServicoConcluido_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<ServicosAdamentoEstrutura> listaServicosAdamentoEstruturas = new List<ServicosAdamentoEstrutura>();
            foreach (ServicosAdamentoEstrutura buscaAparelho in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (buscaAparelho.sv_Aparelho.ToLower().Contains(txt_BuscarServicoConcluido.Text.ToLower()))
                {
                    listaServicosAdamentoEstruturas.Add(buscaAparelho);
                }

                CarregarTabelaPorBusca(listaServicosAdamentoEstruturas);
            }
        }

        private void AlterarInformacaoServico()
        {
            form_AlterarInformacaoServico formulario = new form_AlterarInformacaoServico(this);
            //formulario.btn_Concluido.Visible = false;
            formulario.lbl_Alterar.Text = grid_ServicoConcluido.SelectedCells[0].Value.ToString();
            formulario.txt_Aparelho.Text = grid_ServicoConcluido.SelectedCells[2].Value.ToString();
            formulario.txt_Situacao.Text = grid_ServicoConcluido.SelectedCells[5].Value.ToString();
            formulario.txt_Defeito.Text = grid_ServicoConcluido.SelectedCells[3].Value.ToString();
            formulario.txt_ValorServico.Text = grid_ServicoConcluido.SelectedCells[9].Value.ToString();
            formulario.txt_Senha.Text = grid_ServicoConcluido.SelectedCells[4].Value.ToString();
            formulario.txt_ValorDaPeca.Text = grid_ServicoConcluido.SelectedCells[10].Value.ToString();
            formulario.txt_Acessorios.Text = grid_ServicoConcluido.SelectedCells[6].Value.ToString();
            formulario.txt_ServicoFeito.Text = grid_ServicoConcluido.SelectedCells[12].Value.ToString();
            formulario.txt_DataCadastro.Text = grid_ServicoConcluido.SelectedCells[7].Value.ToString();
            formulario.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int qtdLinhasSelecionadas = grid_ServicoConcluido.SelectedRows.Count;
            if (qtdLinhasSelecionadas == 0)
            {
                MessageBox.Show($"Selecione uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AlterarInformacaoServico();
            }
        }

        private void form_ServicoConcluido_Load(object sender, EventArgs e)
        {
            grid_ServicoConcluido.ClearSelection();
        }

        private void nãoConcluidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ServicosAdamentoEstrutura servico in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (servico.sv_Id == Convert.ToInt32(grid_ServicoConcluido.SelectedCells[0].Value.ToString()))
                {
                    servico.sv_Status = 1;
                    break;
                }
            }
            CarregarTabelaServicosConcluidos();
            grid_ServicoConcluido.ClearSelection();
            //this.Close();
        }
    }
}