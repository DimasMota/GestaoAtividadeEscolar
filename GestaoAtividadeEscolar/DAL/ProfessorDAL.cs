using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProfessorDAL
    {
        public void Cadastrar(ProfessorModels professor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO (Nome, Usuario, Senha) values(@Nome,@Usuario,@Senha";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", professor.Nome);
                cmd.Parameters.AddWithValue("@Usuario", professor.Usuario);
                cmd.Parameters.AddWithValue("@Senha", professor.Senha);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu erro ao tentar cadastrar um usuário no banco de dados.");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ProfessorModels professor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE SET Nome = @Nome,
                                            Usuario = @Usuario,
                                              Senha = @Senha WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", professor.Id);
                cmd.Parameters.AddWithValue("@Nome", professor.Nome);
                cmd.Parameters.AddWithValue("@Usuario", professor.Usuario);
                cmd.Parameters.AddWithValue("@Senha", professor.Senha);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu erro ao tentar alterar um professor no banco de dados.");
            }
            finally
            {
                cn.Close();
            }


        }
        public void Excluir(int id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"DELETE FROM Professor WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar excluir um professor do banco de dados");
            }


        }
        public ProfessorModels BuscarProfessorPorId(int id)
        {
            throw new Exception();
        }
        public ProfessorModels BuscarVerificarUsuarioSenha(string usuario, string senha)
        {
            ProfessorModels professor = new ProfessorModels();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome, Usuario,Senha FROM Professor WHERE Usuario = @Usuario AND Senha == @Senha";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        professor.Id = Convert.ToInt32(rd["Id"]);
                        professor.Nome = Convert.ToString(rd["Nome"]);
                        professor.Usuario = Convert.ToString(rd["Usuario"]);
                        professor.Senha = Convert.ToString(rd["Senha"]);
                    }
                }
                return professor;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar buscar Usuário no Banco de Dados");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

