using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbeariaDoRafao.Classes
{
    public class Usuarios
    {
        #region Propriedades

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }


        #endregion


        #region Construtores

        public Usuarios()
        {
                
        }

        public Usuarios(int id, string nome, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = ativo;      
        }

        #endregion


        #region Métodos

        public static List<Usuarios> BuscarUsuarios()
        {        
            {
               
                string query = string.Format("SELECT * FROM Cliente");
                Conexao cn = new Conexao(query);

                List<Usuarios> usuarios = new List<Usuarios>();

                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader();
                    while (cn.dr.Read())
                    {
                        usuarios.Add(new Cliente()
                        {
                            Id = Convert.ToInt32(cn.dr[0]),
                            Nome = cn.dr[1].ToString(),
                            Email = cn.dr[2].ToString(),
                            Senha = cn.dr[3].ToString(),
                            Genero = cn.dr[4].ToString(),
                            Ativo = Convert.ToBoolean(cn.dr[5]),                          
                            
                        });
                    }
                    return usuarios;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        public static Usuarios RealizarLogin(string email,string senha) 
        {
            string query = string.Format($"SELECT * FROM Funcionario WHERE Email = '{email}'");
            Conexao cn = new Conexao(query);

            Funcionario funcionario = new Funcionario();

            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();

                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        funcionario.Id = Convert.ToInt32(cn.dr[0]);
                        funcionario.Nome = cn.dr[1].ToString();
                        funcionario.Email = cn.dr[2].ToString();
                        funcionario.Senha = cn.dr[3].ToString();
                        funcionario.NivelAcesso = Convert.ToInt32(cn.dr[4]);
                        funcionario.DtNascimento = Convert.ToDateTime(cn.dr[5]);
                        funcionario.DtAdimissao = Convert.ToDateTime(cn.dr[6]);
                        funcionario.DtDemissao = Convert.ToDateTime(cn.dr[7]);
                        funcionario.Salario = Convert.ToDouble(cn.dr[8]);
                        funcionario.Ativo = Convert.ToBoolean(cn.dr[9]);
                    }

                    if (funcionario.Senha == Crypto.Sha256(senha))
                    {
                        if (funcionario.Ativo)
                        {
                            return funcionario;
                        }
                        else
                        {
                            throw new Exception("Usuário bloqueado");
                        }
                    }
                    else
                    {
                        throw new Exception("Senha incorreta");
                    }
                }
                else 
                {
                    throw new Exception("E-mail invalido");
                }
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        #endregion
    }
}
