using SistemaOS.Banco_Global;
using SistemaOS.Clientes;
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

namespace SistemaOS.Financeiro
{
    public partial class form_LucrosGastos : Form
    {
        private List<ServicosAdamentoEstrutura> maioresLucrosGastos;

        public form_LucrosGastos()
        {
            InitializeComponent();
        }

        private void TotalLucrosEGastos()
        {
            decimal totaGastos = 0;

            decimal totalLucro = 0;
            foreach (ServicosAdamentoEstrutura servico in BancoGlobalStatico.listBancoServicosAndamento)
            {
                totalLucro += servico.sv_lucroServico;
                totaGastos += servico.sv_valorPeca;
                if (servico.sv_Status == 0)
                {
                    lbl_TotalGastos.Text = totaGastos.ToString();
                    lbl_TotalLucro.Text = totalLucro.ToString();
                }
            }
        }

        private void AtivarVisibilidadeLabelLucrosEGastos()
        {
            lbl_TextoGastos.Visible = true;
            lbl_TextoLucro.Visible = true;
            lbl_TotalGastos.Visible = true;
            lbl_TotalLucro.Visible = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (date_Final.Value.Date >= date_Inicial.Value.Date && date_Inicial.Value.Date <= date_Final.Value.Date)
                {
                    TotalLucrosEGastos();
                    AtivarVisibilidadeLabelLucrosEGastos();
                }
                else
                {
                    MessageBox.Show($"Informe uma data válida", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}