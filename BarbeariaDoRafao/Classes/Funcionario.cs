using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaDoRafao.Classes
{
    public class Funcionario : Usuarios
    {
        #region Proprietarios


        public int NivelAcesso { get; set; }

        public DateTime DtNascimento { get; set; }

        public DateTime DtAdimissao {get; set; }

        public DateTime DtDemissao { get; set; }

        public double Salario { get; set; }
        #endregion


        #region Construtores

        public Funcionario()
        {

        }

        public Funcionario(int id,string nome, string email, string senha,int nivelAcesso,DateTime dtNascimento,DateTime dtAdimissao,DateTime dtDemissao,double salario, bool ativo) : base(id,nome, email, senha, ativo)
        {
            NivelAcesso = nivelAcesso;
            DtNascimento = dtNascimento;
            DtDemissao = dtDemissao;
            Salario = salario;
      
        }

        #endregion


        #region Métodos



        #endregion

    }
}
