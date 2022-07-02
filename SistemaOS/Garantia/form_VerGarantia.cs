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

namespace SistemaOS.Garantia
{
    public partial class form_VerGarantia : Form
    {
        public form_VerGarantia()
        {
            InitializeComponent();
            CentralizarLabels();
        }

        public string BuscarIdCliente(int id)
        {
            foreach (ClienteEstrutura cliente in BancoGlobalStatico.listBancoCliente)
            {
                if (cliente.cl_Id == id)
                {
                    return cliente.cl_Nome;
                }
            }

            return "";
        }

        public int BuscarGarantia(int _garantia)
        {
            foreach (GarantiaEstrutura garantia in BancoGlobalStatico.listBancoGarantia)
            {
                if (garantia.gar_Id == _garantia)
                {
                    return garantia.gar_fk_idServico;
                }
            }

            return _garantia;
        }

        private DateTime BuscarDataInicialDaGarantia(int _idServico)
        {
            DateTime dataInicial = DateTime.MinValue;

            foreach (GarantiaEstrutura garantia in BancoGlobalStatico.listBancoGarantia)
            {
                if (garantia.gar_fk_idServico == _idServico)
                {
                    dataInicial = garantia.gar_data_Inicial;
                }
            }

            return dataInicial;
        }

        private DateTime BuscarDataFinalDaGarantia(int _idServico)
        {
            DateTime dataFinal = DateTime.MinValue;
            foreach (GarantiaEstrutura garantia in BancoGlobalStatico.listBancoGarantia)
            {
                if (garantia.gar_fk_idServico == _idServico)
                {
                    dataFinal = garantia.gar_data_Final;
                }
            }

            return dataFinal;
        }

        private void btn_Confirmar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_DataEmissao_Click(object sender, EventArgs e)
        {
            //  BuscarDataInicialDaGarantia(Convert.ToInt32(lbl_DataEmissao.Text));
        }

        public void CentralizarLabels()
        {
            lbl_Nome.Left = (this.Width / 2) - (lbl_Nome.Width / 2);
            lbl_Aparelho.Left = (this.Width / 2) - (lbl_Aparelho.Width / 2);
            lbl_Servico.Left = (this.Width / 2) - (lbl_Servico.Width / 2);
            lbl_DataEmissao.Left = (this.Width / 2) - (lbl_DataEmissao.Width / 2);
            lbl_DataFinal.Left = (this.Width / 2) - (lbl_DataFinal.Width / 2);
        }

        private void form_VerGarantia_Load(object sender, EventArgs e)
        {
            CentralizarLabels();
            lbl_DataEmissao.Text = BuscarDataInicialDaGarantia(Convert.ToInt32(lbl_Id.Text)).ToShortDateString();
            lbl_DataFinal.Text = BuscarDataFinalDaGarantia(Convert.ToInt32(lbl_Id.Text)).ToShortDateString();
            // string a = lbl_Id.Text;
        }
    }
}