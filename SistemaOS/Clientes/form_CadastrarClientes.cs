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
    public partial class form_CadastrarClientes : Form
    {
        public form_CadastrarClientes()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparTelaCadastroCliente()
        {
            txt_Id.Text = "";
            txt_Nome.Text = "";
            txt_Cpf.Text = "";
            txt_Telefone.Text = "";
            txt_TelefoneRecado.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nome.Text == "" || txt_Cpf.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos Obrigatórios");
                }
                else
                {
                    BancoGlobalStatico.bancoCliente.Add(new ClienteEstrutura(BancoGlobalStatico.idGlobalCliente, txt_Nome.Text, txt_Cpf.Text, txt_Telefone.Text, txt_TelefoneRecado.Text));
                    BancoGlobalStatico.idGlobalCliente++;
                    BancoGlobalStatico.carregarClientes();
                    MessageBox.Show("Cliente Cadastrado");
                    LimparTelaCadastroCliente();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{ exception.Message}");
            }
        }

        private void txt_Cpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_TelefoneRecado_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}