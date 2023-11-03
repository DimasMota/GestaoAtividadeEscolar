using Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TurmaDAL
    {
        public List<TurmaModels> BuscarTodasTurma(int id)
        {
            List<TurmaModels> turmas = new List<TurmaModels>();
            
            TurmaModels turma;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT T.Id, T.Descricao FROM Professor P INNER JOIN ProfessorTurma PT ON P.Id = PT.IdProfessor
                                                                              INNER JOIN Turma T ON PT.IdTurma = T.Id WHERE P.Id = @id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
               
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        turma = new TurmaModels();
                        turma.Id = Convert.ToInt32(rd["Id"]);
                        turma.Descricao = Convert.ToString(rd["Descricao"]);
                        turmas.Add(turma);
                    }
                }
                return turmas;

            }
            catch (Exception ex)
            {
               
                throw new Exception("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Cadastrar(TurmaModels turma, int idProfessor,SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Turma (Descricao) VALUES(@Descricao) SELECT @@IDENTITY";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", turma.Descricao);


                if (_transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

                int idTurma = Convert.ToInt32(cmd.ExecuteScalar());

                VincularProfessorTurma(idProfessor, idTurma, transaction);

                if (_transaction == null)
                    transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();

                throw new Exception ("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(int idTurma, SqlTransaction _transaction = null)
        {

            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Turma WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", idTurma);


                if (_transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;


                ExcluirVinculoProfessorTurma(Constantes.IdUsuarioLogado, idTurma, transaction);
                ExcluirAtividade(idTurma, transaction);
               cmd.ExecuteNonQuery();

                if (_transaction == null)
                    transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private void ExcluirAtividade(int idTurma, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Atividade WHERE  IdTurma = @IdTurma";
                cmd.CommandType = System.Data.CommandType.Text;

              
                cmd.Parameters.AddWithValue("@IdTurma", idTurma);


                if (_transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

                cmd.ExecuteNonQuery();



                if (_transaction == null)
                    transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados 4", ex);
            }
        }

        private void ExcluirVinculoProfessorTurma(int idUsuarioLogado, int idTurma, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM ProfessorTurma WHERE IdProfessor = @IdProfessor AND IdTurma = @IdTurma";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdProfessor", idUsuarioLogado);
                cmd.Parameters.AddWithValue("@IdTurma", idTurma);


                if (_transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

                cmd.ExecuteNonQuery();



                if (_transaction == null)
                    transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados 3", ex);
            }
        }

        private void VincularProfessorTurma(int idProfessor, int idTurma, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ProfessorTurma (IdProfessor,IdTurma) VALUES (@IdProfessor, @IdTurma)";
                cmd.CommandType = System.Data.CommandType.Text;
             
                cmd.Parameters.AddWithValue("@IdProfessor", idProfessor);
                cmd.Parameters.AddWithValue("@IdTurma", idTurma);


                if (_transaction == null)
                {
                    cn.Open();
                    transaction = cn.BeginTransaction();
                }
                cmd.Transaction = transaction;
                cmd.Connection = transaction.Connection;

               cmd.ExecuteNonQuery();

              

                if (_transaction == null)
                    transaction.Commit();

            }
            catch (Exception ex)
            {
                if (transaction != null && transaction.Connection != null)
                    transaction.Rollback();

                throw new Exception("Ocorreu um erro ao tentar Cadastrar uma turma no banco de dados 2", ex);
            }

        }
    }
}
