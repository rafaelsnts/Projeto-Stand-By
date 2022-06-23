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

namespace SistemaOS.Serviços_em_Andamento
{
    public partial class form_CadastrarServico : Form
    {
        public form_CadastrarServico()
        {
            InitializeComponent();
            BancoGlobalStatico.CarregarClientes();
            CarregarComboboxClientes();
            txt_DataCadastro.Text = DateTime.Now.ToShortDateString();
            txt_DataConclusao.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ServicosAndamento_Click(object sender, EventArgs e)
        {
            form_PanelServicos formulario = new form_PanelServicos();
            formulario.Show();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarComboboxClientes()
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                cmb_IdCliente.Items.Add(cliente.sv_Nome);
            }
        }

        private void LimparTelaCadastroServico()
        {
            txt_Id.Text = "";
            txt_IdCliente.Text = "";
            txt_Aparelho.Text = "";
            txt_Defeito.Text = "";
            txt_Senha.Text = "";
            txt_Situacao.Text = "";
            txt_Acessorios.Text = "";
            txt_DataCadastro.Text = "";
            txt_DataConclusao.Text = "";
            txt_ValorServico.Text = "";
            txt_ValorDaPeca.Text = "";
            txt_LucroServico.Text = "";
            txt_ServicoFeito.Text = "";
            txt_Status.Text = "";
        }

        private decimal[] ValidarCamposServicoPecas()
        {
            decimal valorServico;
            decimal valorPeca;
            if (txt_ValorServico.Text.Length <= 0 && txt_ValorDaPeca.Text.Length <= 0)
            {
                valorServico = 0;
                valorPeca = 0;
            }
            else
            {
                valorServico = txt_ValorServico.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_ValorServico.Text.Replace(".", ","));
                valorPeca = txt_ValorDaPeca.Text.Length <= 0 ? 0 : Convert.ToDecimal(txt_ValorDaPeca.Text.Replace(".", ","));
            }

            return new[] { valorServico, valorPeca };
        }

        private int BuscarIdCliente()
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                if (cliente.sv_Nome == cmb_IdCliente.Text)
                {
                    return cliente.sv_Id;
                }
            }

            return Convert.ToInt32(txt_Id.Text);
        }

        private void CadastrarServico(decimal lucro, decimal valorPeca, decimal valorServico)
        {
            int statusServico = 1;
            BancoGlobalStatico.listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(BancoGlobalStatico.idGlobalServicosAndamento,
               Convert.ToInt32(BuscarIdCliente()), txt_Aparelho.Text, txt_Defeito.Text, txt_Senha.Text, txt_Situacao.Text,
                txt_Acessorios.Text, Convert.ToDateTime(txt_DataCadastro.Text),
                Convert.ToDateTime(txt_DataConclusao.Text), valorServico,
                valorPeca, lucro,
                txt_ServicoFeito.Text, statusServico));
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal lucro = ValidarCamposServicoPecas()[0] - ValidarCamposServicoPecas()[1];
                if (txt_Aparelho.Text == "" || txt_Defeito.Text == "" || cmb_IdCliente.SelectedItem.ToString() == null)
                {
                    MessageBox.Show("Preencha todos os campos Obrigatórios");
                }
                else
                {
                    decimal valorServico = ValidarCamposServicoPecas()[0];
                    decimal valorPeca = ValidarCamposServicoPecas()[1];
                    CadastrarServico(lucro, valorPeca, valorServico);
                    BancoGlobalStatico.idGlobalIdCliente++;
                    BancoGlobalStatico.idGlobalServicosAndamento++;
                    BancoGlobalStatico.CarregarServicosAndamento();
                    MessageBox.Show("Serviço Cadastrado");
                    LimparTelaCadastroServico();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{ exception.Message}");
            }
        }

        private void ValidarApenasNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void ValidarData(object sender, KeyPressEventArgs e)
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

        private void ValidarValores(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void TextboxApenasNumerosLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_Aparelho_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_Defeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_Situacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_Acessorios_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_ServicoFeito_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextboxApenasNumerosLetras(sender, e);
        }

        private void txt_Status_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarApenasNumeros(sender, e);
        }

        private void txt_DataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarData(sender, e);
        }

        private void txt_DataConclusao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarData(sender, e);
        }

        private void cmb_IdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarApenasNumeros(sender, e);
        }

        private void txt_ValorDaPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarValores(sender, e);
        }

        private void txt_ValorServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarValores(sender, e);
        }

        private void txt_LucroServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarValores(sender, e);
        }
    }
}