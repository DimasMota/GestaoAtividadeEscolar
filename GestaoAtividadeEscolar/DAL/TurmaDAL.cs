using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TurmaDAL
    {
        public void Cadastrar(Turma turma)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Turma (Nome, IdProfessor) VALUES (@Nome,@Id)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", turma.Nome);
                cmd.Parameters.AddWithValue("@Id", Constantes.IdUsuarioLogado);

                cn.Open();

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar cadastrar uma turma o banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Turma> BuscarTodasTurmas(int idprofessor)
        {
            List<Turma> turmas = new List<Turma>();
            Turma turma;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome FROM Turma WHERE IdProfessor = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", idprofessor);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        turma = new Turma();
                        turma.Id = Convert.ToInt32(rd["Id"]);
                        turma.Nome = Convert.ToString(rd["Nome"]);
                        turmas.Add(turma);

                    }
                }
                return turmas;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar acessar o banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Excluir(int idTurma)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Turma WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", idTurma);

                cn.Open();

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar Excluir uma turma do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public bool VerificarVinculoAtividade(int idTurma)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT 1 FROM Atividade WHERE IdTurma = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", idTurma);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar verificar vínculo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
