using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOS.Serviços_em_Andamento;

namespace SistemaOS.Banco_Global
{
    internal class BancoGlobalStatico
    {
        public static List<ServicosAdamentoEstrutura> bancoServicosAndamento = new List<ServicosAdamentoEstrutura>();
        public static int idGlobalServicosAndamento = 6;
        public static int idGlobalIdCliente = 6;
        public static bool isServicosAndamentoInicializada { get; set; }

        public static void carregarServicosAndamento()
        {
            if (isServicosAndamentoInicializada == false)
            {
                bancoServicosAndamento.Add(new ServicosAdamentoEstrutura(1, 1, "Galaxy S20", "Display", "123r5", "Display não liga", "Cartão SD", DateTime.Now, DateTime.Now, 60, 20, 40, "Troca do display", 1));
                bancoServicosAndamento.Add(new ServicosAdamentoEstrutura(2, 2, "Galaxy S10", "Display", "123sr5", "Display não liga", "Carregador", DateTime.Now, DateTime.Now, 70, 40, 30, "Troca do display", 1));
                bancoServicosAndamento.Add(new ServicosAdamentoEstrutura(3, 3, "Iphone 8", "Display", "12a3r5", "Display não liga", "N/A", DateTime.Now, DateTime.Now, 80, 40, 40, "Troca do display", 1));
                bancoServicosAndamento.Add(new ServicosAdamentoEstrutura(4, 4, "Moto G 9", "Display", "1243r5", "Display não liga", "Capa", DateTime.Now, DateTime.Now, 100, 50, 50, "Troca do display", 1));
                bancoServicosAndamento.Add(new ServicosAdamentoEstrutura(5, 5, "Xiaomi Redminote 8 pro", "Display", "12a3r5", "Display não liga", "N/A", DateTime.Now.Date, DateTime.Now.Date, 110, 60, 50, "Troca do display", 1));
                isServicosAndamentoInicializada = true;
            }
        }
    }
}