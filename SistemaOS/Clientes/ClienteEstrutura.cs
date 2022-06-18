using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOS.Clientes
{
    public class ClienteEstrutura
    {
        public int sv_Id { get; set; }
        public string sv_Nome { get; set; }
        public string sv_Telefone { get; set; }
        public string sv_Cpf { get; set; }
        public string sv_Telefone_Recado { get; set; }

        public ClienteEstrutura(int _sv_id, string _sv_nome, string _sv_telefone, string _sv_cpf, string _sv_telefoneRecado)
        {
            sv_Id = _sv_id;
            sv_Nome = _sv_nome;
            sv_Telefone = _sv_telefone;
            sv_Cpf = _sv_cpf;
            sv_Telefone_Recado = _sv_telefoneRecado;
        }
    }
}