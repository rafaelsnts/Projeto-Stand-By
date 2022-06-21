using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOS.Clientes
{
    public partial class form_PanelClientes : Form
    {
        public form_PanelClientes()
        {
            InitializeComponent();
        }

        private void showChildForminPanel(object Form)
        {
            if (this.pnl_Clientes.Controls.Count > 0)
            {
                this.pnl_Clientes.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_Clientes.Controls.Add(form);
            form.Show();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Clientes());
        }

        private void btn_CadastrarClientes_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_CadastrarClientes());
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.FromArgb(28, 27, 32);
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }

        private void btn_Fechar_MouseEnter(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.FromArgb(28, 27, 32);
        }

        private void btn_Fechar_MouseLeave(object sender, EventArgs e)
        {
            btn_Fechar.BackColor = Color.Transparent;
        }
    }
}