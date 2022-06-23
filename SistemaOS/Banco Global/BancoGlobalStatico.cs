using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaOS.Clientes;
using SistemaOS.Serviços_em_Andamento;

namespace SistemaOS.Banco_Global
{
    internal class BancoGlobalStatico
    {
        // Carregar estrutura Serviço em andamento
        public static List<ServicosAdamentoEstrutura> listBancoServicosAndamento = new List<ServicosAdamentoEstrutura>();

        public static int idGlobalServicosAndamento = 6;
        public static int idGlobalIdCliente = 6;
        public static bool isServicosAndamentoInicializada { get; set; }

        // Carregar estrutura Cliente
        public static List<ClienteEstrutura> listBancoCliente = new List<ClienteEstrutura>();

        public static int idGlobalCliente = 6;
        public static bool isClienteInicializada { get; set; }

        public static void CarregarServicosAndamento()
        {
            if (isServicosAndamentoInicializada == false)
            {
                listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(1, 1, "Galaxy S20", "Display", "123r5", "Display não liga", "Cartão SD", DateTime.Now, DateTime.Now, 60, 20, 40, "Troca do display", 1));
                listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(2, 2, "Galaxy S10", "Display", "123sr5", "Display não liga", "Carregador", DateTime.Now, DateTime.Now, 70, 40, 30, "Troca do display", 1));
                listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(3, 3, "Iphone 8", "Display", "12a3r5", "Display não liga", "N/A", DateTime.Now, DateTime.Now, 80, 40, 40, "Troca do display", 1));
                listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(4, 4, "Moto G 9", "Display", "1243r5", "Display não liga", "Capa", DateTime.Now, DateTime.Now, 100, 50, 50, "Troca do display", 1));
                listBancoServicosAndamento.Add(new ServicosAdamentoEstrutura(5, 5, "Xiaomi Redminote 8 pro", "Display", "12a3r5", "Display não liga", "N/A", DateTime.Now.Date, DateTime.Now.Date, 110, 60, 50, "Troca do display", 1));
                isServicosAndamentoInicializada = true;
            }
        }

        public static void CarregarClientes()
        {
            if (isClienteInicializada == false)
            {
                listBancoCliente.Add(new ClienteEstrutura(1, "Rafael", "055.955.251-00", "(71)99177-3340", "(71)99177-3350"));
                listBancoCliente.Add(new ClienteEstrutura(2, "Israel", "055.955.251-01", "(71)99177-3341", "(71)99177-3351"));
                listBancoCliente.Add(new ClienteEstrutura(3, "Adriano", "055.955.251-02", "(71)99177-3342", "(71)99177-3352"));
                listBancoCliente.Add(new ClienteEstrutura(4, "Robinho", "055.955.251-03", "(71)99177-3343", "(71)99177-3353"));
                listBancoCliente.Add(new ClienteEstrutura(5, "Thiago", "055.955.251-04", "(71)99177-3344", "(71)99177-3354"));
                isClienteInicializada = true;
            }
        }
    }
}