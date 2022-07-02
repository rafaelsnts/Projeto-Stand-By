using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaOS.Clientes;
using SistemaOS.Serviços_Concluidos;
using SistemaOS.Serviços_em_Andamento;
using SistemaOS.Banco_Global;

namespace SistemaOS.Financeiro
{
    public partial class form_PanelEstatisticas : Form
    {
        public form_PanelEstatisticas()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void showChildForminPanel(object Form)
        {
            if (this.pnl_Financeiro.Controls.Count > 0)
            {
                this.pnl_Financeiro.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_Financeiro.Controls.Add(form);
            form.Show();
        }

        private void btn_TopClientes_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Estatisticas());
        }

        private void btn_LucrosGastos_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_LucrosGastos());
        }

        private void btn_Prejuizos_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Prejuizo());
        }

        private void btn_Lucros_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Lucro());
        }
    }
}