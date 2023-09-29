using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BarbeariaDoRafao.Classes
{
    public class Servico
    {

        #region Proprietarios

        public int Id { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

        public int TempoEstimado { get; set; }

        public bool Ativo { get; set; }



        #endregion



        #region Construtores

        public Servico()
        {
            
        }

        public Servico(int id, string nome, double valor, int tempoEstimado, bool ativo)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            TempoEstimado = tempoEstimado;
            Ativo = ativo;
        }


        #endregion



        #region Métodos


        public void Excluir()
        {
            string query = string.Format($"UPDATE Servico SET Ativo = 0 WHERE Id = {Id}");
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
            string query = string.Format($"UPDATE Servico SET Ativo = 0 WHERE Id = {Id}");
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


        public void Alterar()
        {
            string query = string.Format($"UPDATE Servico SET Nome = '{Nome}', Valor = {Valor}, TempoEstimado = {TempoEstimado} WHERE Id = {Id}");
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

        public void CadastrarServicos(List<Servico> servicos)
        {
            string query = string.Format($" INSERT INTO Servico VALUES ('{Nome}',{Valor},{TempoEstimado},1)");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                servicos.Add(this);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static List<Servico> BuscarServicos()
        {
            {
                string query = string.Format($"Select * from Servico");
                Conexao cn = new Conexao(query);

                List<Servico> servicos = new List<Servico>();

                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader();
                    while (cn.dr.Read())
                    {

                        servicos.Add(new Servico()
                        {
                            Id = Convert.ToInt32(cn.dr[0]),
                            Nome = cn.dr[1].ToString(),
                            Valor = Convert.ToDouble(cn.dr[2]),
                            TempoEstimado = Convert.ToInt32(cn.dr[3]),
                            Ativo = Convert.ToBoolean(cn.dr[4]),

                        });
                        

                    }
                    return servicos;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        #endregion
    }
}
