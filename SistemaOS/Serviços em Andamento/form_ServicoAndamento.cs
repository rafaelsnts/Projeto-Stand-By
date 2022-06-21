using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaOS.Banco_Global;
using SistemaOS.Clientes;
using SistemaOS.Serviços;

namespace SistemaOS.Serviços_em_Andamento
{
    public partial class form_ServicoAndamento : Form

    {
        public form_ServicoAndamento()
        {
            InitializeComponent();
            BancoGlobalStatico.carregarClientes();
            BancoGlobalStatico.carregarServicosAndamento();
            carregarTabelaServicosAndamento();
        }

        public string BuscarNomeCliente(int id)
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.bancoCliente)
            {
                if (cliente.sv_Id == id)
                {
                    return cliente.sv_Nome;
                }
            }

            return "";
        }

        public void carregarTabelaServicosAndamento()
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

            foreach (ServicosAdamentoEstrutura servicoAndamento in BancoGlobalStatico.bancoServicosAndamento)
            {
                dt.Rows.Add(servicoAndamento.sv_Id, BuscarNomeCliente(servicoAndamento.sv_fk_cl_idCliente), servicoAndamento.sv_Aparelho,
                    servicoAndamento.sv_Defeito, servicoAndamento.sv_Senha, servicoAndamento.sv_Situacao,
                    servicoAndamento.sv_Acessorios, servicoAndamento.sv_dataCadastro.ToShortDateString(),
                    servicoAndamento.sv_dataConclusao.ToShortDateString(), string.Format("{0:0.00}", servicoAndamento.sv_valorServico),
                    string.Format("{0:0.00}", servicoAndamento.sv_valorPeca), string.Format("{0:0.00}", servicoAndamento.sv_lucroServico), servicoAndamento.sv_servicoFeito,
                    (servicoAndamento.sv_Status) == 1 ? "Em andamento" : "Concluido");
            }

            grid_ServicoAndamento.DataSource = dt;
        }

        public void carregarTabelaPorBusca(List<ServicosAdamentoEstrutura> _servicosAdamento)
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

            foreach (ServicosAdamentoEstrutura servicoAndamento in _servicosAdamento)
            {
                dt.Rows.Add(servicoAndamento.sv_Id, BuscarNomeCliente(servicoAndamento.sv_fk_cl_idCliente), servicoAndamento.sv_Aparelho,
                    servicoAndamento.sv_Defeito, servicoAndamento.sv_Senha, servicoAndamento.sv_Situacao,
                    servicoAndamento.sv_Acessorios, servicoAndamento.sv_dataCadastro.ToShortDateString(),
                    servicoAndamento.sv_dataConclusao.ToShortDateString(), string.Format("{0:0.00}", servicoAndamento.sv_valorServico),
                    string.Format("{0:0.00}", servicoAndamento.sv_valorPeca), string.Format("{0:0.00}", servicoAndamento.sv_lucroServico), servicoAndamento.sv_servicoFeito,
                    (servicoAndamento.sv_Status) == 1 ? "Em andamento" : "Concluido");
            }

            grid_ServicoAndamento.DataSource = dt;
        }

        private void txt_Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            List<ServicosAdamentoEstrutura> listaServicosAdamentoEstruturas = new List<ServicosAdamentoEstrutura>();
            foreach (ServicosAdamentoEstrutura buscaAparelho in BancoGlobalStatico.bancoServicosAndamento)
            {
                if (buscaAparelho.sv_Aparelho.ToLower().Contains(txt_Buscar.Text.ToLower()))
                {
                    listaServicosAdamentoEstruturas.Add(buscaAparelho);
                }

                carregarTabelaPorBusca(listaServicosAdamentoEstruturas);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            List<ServicosAdamentoEstrutura> listaServicosAdamentoEstruturas = new List<ServicosAdamentoEstrutura>();
            foreach (ServicosAdamentoEstrutura buscaAparelho in BancoGlobalStatico.bancoServicosAndamento)
            {
                if (buscaAparelho.sv_Aparelho == txt_Buscar.Text)
                {
                    listaServicosAdamentoEstruturas.Add(buscaAparelho);
                }

                carregarTabelaPorBusca(listaServicosAdamentoEstruturas);
            }
        }

        private void alterarInformacaoServico()
        {
            form_AlterarInformacaoServico formulario = new form_AlterarInformacaoServico(this);
            formulario.lbl_Alterar.Text = grid_ServicoAndamento.SelectedCells[0].Value.ToString();
            formulario.txt_Aparelho.Text = grid_ServicoAndamento.SelectedCells[2].Value.ToString();
            formulario.txt_Situacao.Text = grid_ServicoAndamento.SelectedCells[5].Value.ToString();
            formulario.txt_Defeito.Text = grid_ServicoAndamento.SelectedCells[3].Value.ToString();
            formulario.txt_ValorServico.Text = grid_ServicoAndamento.SelectedCells[9].Value.ToString();
            formulario.txt_Senha.Text = grid_ServicoAndamento.SelectedCells[4].Value.ToString();
            formulario.txt_ValorDaPeca.Text = grid_ServicoAndamento.SelectedCells[10].Value.ToString();
            formulario.txt_Acessorios.Text = grid_ServicoAndamento.SelectedCells[6].Value.ToString();
            formulario.txt_ServicoFeito.Text = grid_ServicoAndamento.SelectedCells[12].Value.ToString();
            formulario.txt_DataCadastro.Text = grid_ServicoAndamento.SelectedCells[7].Value.ToString();
            formulario.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int qtdLinhasSelecionadas = grid_ServicoAndamento.SelectedRows.Count;
            if (qtdLinhasSelecionadas == 0)
            {
                MessageBox.Show($"Selecione uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                alterarInformacaoServico();
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = grid_ServicoAndamento.SelectedRows.Count;
            if (linhaSelecionada == 0)
            {
                MessageBox.Show($"Selecione uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string excluirServicoAndamento = grid_ServicoAndamento.SelectedCells[2].Value.ToString();
            foreach (ServicosAdamentoEstrutura servicoAndamento in BancoGlobalStatico.bancoServicosAndamento)
            {
                if (excluirServicoAndamento == servicoAndamento.sv_Aparelho)
                {
                    if (MessageBox.Show("Tem certeza?", "CERTEZA", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        BancoGlobalStatico.bancoServicosAndamento.Remove(servicoAndamento);
                        carregarTabelaServicosAndamento();
                        break;
                    }
                }
            }
        }

        private void form_ServicoAndamento_Load(object sender, EventArgs e)
        {
            grid_ServicoAndamento.ClearSelection();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}