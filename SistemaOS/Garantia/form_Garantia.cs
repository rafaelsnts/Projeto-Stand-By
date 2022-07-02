using SistemaOS.Banco_Global;
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
using SistemaOS.Clientes;
using SistemaOS.Serviços_Concluidos;

namespace SistemaOS.Garantia
{
    public partial class form_Garantia : Form
    {
        public form_Garantia()
        {
            InitializeComponent();
        }

        private int BuscarIdCliente(int _idServico)
        {
            foreach (ServicosAdamentoEstrutura servico in BancoGlobalStatico.listBancoServicosAndamento)
            {
                if (servico.sv_Id == _idServico)
                {
                    return servico.sv_fk_cl_idCliente;
                }
            }

            return 0;
        }

        private void InserirQtdDiasGarantia()
        {
            DateTime dataInicial = DateTime.Now.Date;
            int qtdDiasGarantia = Convert.ToInt32(txt_QtdGarantia.Text);
            DateTime dataFinaldaGarantia = dataInicial.AddDays(qtdDiasGarantia);

            int idGarantia = BancoGlobalStatico.listBancoGarantia.Count;
            int idServico = Convert.ToInt32(lbl_IdServico1.Text);
            int idCliente = BuscarIdCliente(idServico);

            BancoGlobalStatico.listBancoGarantia.Add(new GarantiaEstrutura(idGarantia, idServico, idCliente, dataFinaldaGarantia));
            MessageBox.Show($"Serviço concluido com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btn_InserirGarantia_Click(object sender, EventArgs e)
        {
            if (txt_QtdGarantia.Text == "")
            {
                MessageBox.Show($"Insira a quantidade de dias da garantia", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                InserirQtdDiasGarantia();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void txt_QtdGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}