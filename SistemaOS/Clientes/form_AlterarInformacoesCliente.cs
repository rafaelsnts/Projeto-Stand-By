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

namespace SistemaOS.Clientes
{
    public partial class form_AlterarInformacoesCliente : Form
    {
        private form_Clientes form_Clientes;

        public form_AlterarInformacoesCliente(form_Clientes _form_Clientes)
        {
            InitializeComponent();
            form_Clientes = _form_Clientes;
        }

        private void SalvarAlteracoes()
        {
            foreach (ClienteEstrutura alterar in BancoGlobalStatico.listBancoCliente)
            {
                if (alterar.cl_Id == Convert.ToInt32(lbl_IdCliente.Text))
                {
                    alterar.cl_Nome = txt_Nome.Text;
                    alterar.cl_Cpf = txt_Cpf.Text;
                    alterar.cl_Telefone = txt_Telefone.Text;
                    alterar.cl_Telefone_Recado = txt_TelefoneRecado.Text;
                    MessageBox.Show("Informações alteradas com Sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form_Clientes.CarregarTabelaCliente();
                    form_Clientes.grid_Clientes.ClearSelection();
                    this.Close();
                    break;
                }
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarAlteracoes();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextboxApenasLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void ValidarCpf(object sender, KeyPressEventArgs e)
        {
            TextBox Cpf = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Cpf.SelectionStart = Cpf.Text.Length + 1;
                if (Cpf.TextLength == 3 || Cpf.TextLength == 7)
                    Cpf.Text += ".";
                else if (Cpf.TextLength == 11)
                    Cpf.Text += "-";
                else if (Cpf.TextLength == 15)
                    Cpf.Text += "-";
                Cpf.SelectionStart = Cpf.TextLength + 1;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void ValidarTelefone(object sender, KeyPressEventArgs e)
        {
            TextBox Tel = sender as TextBox;
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                Tel.SelectionStart = Tel.Text.Length + 1;

                if (Tel.Text.Length == 0 || Tel.Text.Length == 1)
                    Tel.Text += "(";
                else if (Tel.Text.Length == 3)
                    Tel.Text += ")";
                else if (Tel.Text.Length == 8)
                    Tel.Text += "-";
                Tel.SelectionStart = Tel.Text.Length + 1;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasLetras(sender, e);
        }

        private void txt_Cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarCpf(sender, e);
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTelefone(sender, e);
        }

        private void txt_TelefoneRecado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTelefone(sender, e);
        }
    }
}