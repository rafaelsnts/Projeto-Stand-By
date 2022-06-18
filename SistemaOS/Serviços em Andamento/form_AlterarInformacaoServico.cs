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
using SistemaOS.Serviços_Concluidos;
using SistemaOS.Serviços_em_Andamento;

namespace SistemaOS.Serviços
{
    public partial class form_AlterarInformacaoServico : Form
    {
        private form_ServicoAndamento form_ServicoAndamento;

        public form_AlterarInformacaoServico(form_ServicoAndamento _form_ServicoAndamento)
        {
            InitializeComponent();
            form_ServicoAndamento = _form_ServicoAndamento;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            foreach (ServicosAdamentoEstrutura alterar in BancoGlobalStatico.bancoServicosAndamento)
            {
                if (alterar.sv_Id == Convert.ToInt32(lbl_Alterar.Text))
                {
                    alterar.sv_Aparelho = txt_Aparelho.Text;
                    alterar.sv_Situacao = txt_Situacao.Text;
                    alterar.sv_Defeito = txt_Defeito.Text;
                    alterar.sv_valorServico = Convert.ToDecimal(txt_ValorServico.Text == "" ? "0" : txt_ValorServico.Text);
                    alterar.sv_Senha = txt_Senha.Text;
                    alterar.sv_valorPeca = Convert.ToDecimal(txt_ValorDaPeca.Text == "" ? "0" : txt_ValorDaPeca.Text);
                    alterar.sv_Acessorios = txt_Acessorios.Text;
                    alterar.sv_servicoFeito = txt_ServicoFeito.Text;
                    alterar.sv_dataCadastro = Convert.ToDateTime(txt_DataCadastro.Text);
                    MessageBox.Show("Informações alteradas com Sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form_ServicoAndamento.carregarTabelaServicosAndamento();
                    form_ServicoAndamento.grid_ServicoAndamento.ClearSelection();
                    this.Close();
                    break;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Situacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_Aparelho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_Defeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_Acessorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_ServicoFeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_DataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox Data = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Data.SelectionStart = Data.Text.Length + 1;

                if (Data.Text.Length == 2 || Data.Text.Length == 5)
                    Data.Text += "/";
                else if (Data.Text.Length == 10)
                    Data.Text += "";
                Data.SelectionStart = Data.Text.Length + 1;
            }
        }
    }
}