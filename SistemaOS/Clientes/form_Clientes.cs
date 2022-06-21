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
using SistemaOS.Serviços_em_Andamento;

namespace SistemaOS.Clientes
{
    public partial class form_Clientes : Form
    {
        public form_Clientes()
        {
            InitializeComponent();
            BancoGlobalStatico.carregarServicosAndamento();
            BancoGlobalStatico.carregarClientes();
            CarregarTabelaCliente();
        }

        public void CarregarTabelaCliente()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOME");
            dt.Columns.Add("CPF");
            dt.Columns.Add("TELEFONE");
            dt.Columns.Add("TELEFONE RECADO");

            foreach (ClienteEstrutura cliente in BancoGlobalStatico.bancoCliente)
            {
                dt.Rows.Add(cliente.sv_Id, cliente.sv_Nome, cliente.sv_Cpf, cliente.sv_Telefone,
                    cliente.sv_Telefone_Recado);
            }
            grid_Clientes.DataSource = dt;
        }

        public void CarregarTabelaPorBusca(List<ClienteEstrutura> _cliente)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOME");
            dt.Columns.Add("CPF");
            dt.Columns.Add("TELEFONE");
            dt.Columns.Add("TELEFONE RECADO");

            foreach (ClienteEstrutura cliente in _cliente)
            {
                dt.Rows.Add(cliente.sv_Id, cliente.sv_Nome, cliente.sv_Cpf, cliente.sv_Telefone,
                    cliente.sv_Telefone_Recado);
            }
            grid_Clientes.DataSource = dt;
        }

        private void txt_BuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            List<ClienteEstrutura> listaClienteEstrutura = new List<ClienteEstrutura>();
            foreach (ClienteEstrutura buscaCliente in BancoGlobalStatico.bancoCliente)
            {
                if (buscaCliente.sv_Nome.ToLower().Contains(txt_BuscarCliente.Text.ToLower()) || buscaCliente.sv_Cpf.ToLower().Contains(txt_BuscarCliente.Text.ToLower()))
                {
                    listaClienteEstrutura.Add(buscaCliente);
                }
                CarregarTabelaPorBusca(listaClienteEstrutura);
            }
        }

        private void AlterarInformacoesCliente()
        {
            form_AlterarInformacoesCliente formulario = new form_AlterarInformacoesCliente(this);
            formulario.lbl_IdCliente.Text = grid_Clientes.SelectedCells[0].Value.ToString();
            formulario.txt_Nome.Text = grid_Clientes.SelectedCells[1].Value.ToString();
            formulario.txt_Cpf.Text = grid_Clientes.SelectedCells[2].Value.ToString();
            formulario.txt_Telefone.Text = grid_Clientes.SelectedCells[3].Value.ToString();
            formulario.txt_TelefoneRecado.Text = grid_Clientes.SelectedCells[4].Value.ToString();
            formulario.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int qtdLinhasSelecionadas = grid_Clientes.SelectedRows.Count;
            if (qtdLinhasSelecionadas == 0)
            {
                MessageBox.Show($"Selecione uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AlterarInformacoesCliente();
            }
        }

        private void form_Clientes_Load(object sender, EventArgs e)
        {
            grid_Clientes.ClearSelection();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = grid_Clientes.SelectedRows.Count;
            if (linhaSelecionada == 0)
            {
                MessageBox.Show($"Selecione uma linha", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                string idCliente = grid_Clientes.SelectedCells[0].Value.ToString();
                foreach (ServicosAdamentoEstrutura servicoAndamento in BancoGlobalStatico.bancoServicosAndamento)
                {
                    if (idCliente == servicoAndamento.sv_fk_cl_idCliente.ToString())
                    {
                        MessageBox.Show($"Esse cliente possui serviços cadastrados no sistema", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CarregarTabelaCliente();
                        return;
                    }
                }

                foreach (ClienteEstrutura cliente in BancoGlobalStatico.bancoCliente)
                {
                    if (idCliente == cliente.sv_Id.ToString())
                    {
                        MessageBox.Show($"Tem certeza?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        BancoGlobalStatico.bancoCliente.Remove(cliente);
                        break;
                    }
                }
                CarregarTabelaCliente();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}");
            }
        }

        private void txt_BuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 46 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
    }
}