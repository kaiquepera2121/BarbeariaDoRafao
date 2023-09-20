using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaDoRafao.Classes
{
    internal class Usuarios
    {
        #region Propriedades

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }


        #endregion


        #region Construtores

        public Usuarios()
        {
                
        }

        public Usuarios(string nome, string email, string senha, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        #endregion


        #region Métodos

        public static Usuarios RealizarLogin() 
        {

        }


        #endregion
    }
}
