using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaDoRafao.Classes
{
    internal class Cliente : Usuarios
    {

        #region Propriedades


        public string Genero { get; set; }


        #endregion



        #region Construtores

        public Cliente()
        {

        }

        public Cliente(string nome, string email, string senha,string genero, bool ativo) : base(nome, email, senha, ativo)
        {
            Genero = genero;
        }

        #endregion


        #region Métodos



        #endregion
    }
}
