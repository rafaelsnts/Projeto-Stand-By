using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOS.Serviços_em_Andamento
{
    public partial class form_Panel : Form
    {
        public form_Panel()
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

        private void btn_Minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CadastrarServicos_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_CadastrarServico());
        }

        private void showChildForminPanel(object Form)
        {
            if (this.pnl_ServicosAndamento.Controls.Count > 0)
            {
                this.pnl_ServicosAndamento.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_ServicosAndamento.Controls.Add(form);
            form.Show();
        }

        private void btn_ServicosAndamento_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_ServicoAndamento());
        }

        private void btn_Minimizar_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.FromArgb(28, 27, 32);
        }

        private void btn_Minimizar_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimizar.BackColor = Color.Transparent;
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