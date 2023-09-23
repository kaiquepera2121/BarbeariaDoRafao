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

        public Cliente(int id, string nome, string email, string senha, string genero, bool ativo) : base(id, nome, email, senha, ativo)
        {
            Genero = genero;
        }

        #endregion


        #region Métodos

        public void Cadastrar(List<Cliente> clientes)
        {
            string query = string.Format($" INSERT INTO Cliente VALUES ('{Nome}','{Email}','{Crypto.Sha256("123")}','{Genero}',1)");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                clientes.Add(this);
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Alterar()
        {
            string query = string.Format($"Update Cliente set Nome = '{Nome}',Email = '{Email}',Genero = '{Genero}' where id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }


        public void Ativar()
        {
            string query = string.Format($"UPDATE Cliente SET Ativo = 1 WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }


        }

        public static List<Cliente> Buscar(List<Cliente> clientes, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:

                    return clientes.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();
              
                case 1:
                

                    return clientes.Where(a => a.Email.Contains(texto)).ToList();

         
                case 2:
  

                    return clientes.Where(a => a.Id == Convert.ToInt32(texto)).ToList();

                default:
              

                    return clientes;

            }
        }

        public void Excluir()
        {
            string query = string.Format($"UPDATE Cliente SET Ativo = 0 WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }

          
        }
        #endregion
    }
}
