using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOS.Clientes
{
    public class ClienteEstrutura
    {
        public int cl_Id { get; set; }
        public string cl_Nome { get; set; }
        public string cl_Cpf { get; set; }
        public string cl_Telefone { get; set; }
        public string cl_Telefone_Recado { get; set; }

        public ClienteEstrutura(int clId, string clNome, string clCpf, string clTelefone, string clTelefoneRecado)
        {
            cl_Id = clId;
            cl_Nome = clNome;
            cl_Cpf = clCpf;
            cl_Telefone = clTelefone;
            cl_Telefone_Recado = clTelefoneRecado;
        }
    }
}