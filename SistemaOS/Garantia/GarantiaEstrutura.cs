using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOS.Garantia
{
    public class GarantiaEstrutura
    {
        public int gar_Id { get; set; }
        public int gar_fk_idServico { get; set; }
        public int gar_fk_idCliente { get; set; }
        public DateTime gar_data_Inicial { get; set; }
        public DateTime gar_data_Final { get; set; }

        public GarantiaEstrutura(int _gar_Id, int _gar_fk_idServico, int _gar_fk_idCliente, DateTime _gar_data_Inicial,
            DateTime _gar_data_Final)
        {
            gar_Id = _gar_Id;
            gar_fk_idServico = _gar_fk_idServico;
            gar_fk_idCliente = _gar_fk_idCliente;
            gar_data_Inicial = DateTime.Now;
            gar_data_Final = _gar_data_Final;
        }
    }
}