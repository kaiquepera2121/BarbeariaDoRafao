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
            DtAdimissao = dtAdimissao;
            DtDemissao = dtDemissao;
            Salario = salario;
      
        }

        #endregion


        #region Métodos

        public void Cadastrar(List<Funcionario> funcionarios)
        {
            string query = string.Format($" INSERT INTO Funcionario VALUES ('{Nome}','{Email}','{Crypto.Sha256("123")}',{NivelAcesso},'{DtNascimento}','{DtAdimissao}','',{Salario},1)");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                funcionarios.Add(this);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Alterar()
        {
            string query = string.Format($"UPDATE Funcionario SET Nome = '{Nome}', Email = '{Email}', DtNascimento = '{DtNascimento}' WHERE Id = {Id}");
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

        public static List<Funcionario> Buscar(List<Funcionario> funcionarios, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:

                    return funcionarios.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();

                case 1:


                    return funcionarios.Where(a => a.Email.Contains(texto)).ToList();


                case 2:


                    return funcionarios.Where(a => a.Id == Convert.ToInt32(texto)).ToList();

                default:


                    return funcionarios;

            }
        }

        public void Excluir()
        {
            string query = string.Format($"UPDATE Funcionario SET Ativo = 0 WHERE Id = {Id}");
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
            string query = string.Format($"UPDATE Funcionario SET Ativo = 1 WHERE Id = {Id}");
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
