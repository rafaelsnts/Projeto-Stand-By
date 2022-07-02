using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOS.Serviços_em_Andamento
{
    public class ServicosAdamentoEstrutura
    {
        public int sv_Id { get; set; }
        public int sv_fk_cl_idCliente { get; set; }
        public string sv_Aparelho { get; set; }
        public string sv_Defeito { get; set; }
        public string sv_Senha { get; set; }
        public string sv_Situacao { get; set; }
        public string sv_Acessorios { get; set; }
        public DateTime sv_dataCadastro { get; set; }
        public DateTime sv_dataConclusao { get; set; }
        public decimal sv_valorServico { get; set; }
        public decimal sv_valorPeca { get; set; }
        public decimal sv_lucroServico { get; set; }
        public string sv_servicoFeito { get; set; }
        public int sv_Status { get; set; }

        public ServicosAdamentoEstrutura(int _sv_Id, int _sv_fk_cl_idCliente, string _sv_Aparelho, string _sv_Defeito,
            string _sv_Senha, string _sv_Situacao, string _sv_Acessorios, DateTime _sv_DataCadastro,
             decimal _sv_valorServico, decimal _sv_valorPeca, decimal _sv_lucroServico, string _sv_servicoFeito, int _sv_Status)
        {
            sv_Id = _sv_Id;
            sv_fk_cl_idCliente = _sv_fk_cl_idCliente;
            sv_Aparelho = _sv_Aparelho;
            sv_Defeito = _sv_Defeito;
            sv_Senha = _sv_Senha;
            sv_Situacao = _sv_Situacao;
            sv_Acessorios = _sv_Acessorios;
            sv_dataCadastro = DateTime.Now.Date;
            sv_valorServico = _sv_valorServico;
            sv_valorPeca = _sv_valorPeca;
            sv_lucroServico = _sv_lucroServico;
            sv_servicoFeito = _sv_servicoFeito;
            sv_Status = _sv_Status;
        }
    }
}