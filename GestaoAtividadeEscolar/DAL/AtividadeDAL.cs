using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AtividadeDAL
    {
        public void Cadastrar(Atividade atividade, int idTurma)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Atividade (Nome, IdTurma) VALUES (@Nome,@Id)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", atividade.Nome);
                cmd.Parameters.AddWithValue("@Id", idTurma);

                cn.Open();

                cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar cadastrar uma atividade no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Atividade> BuscarTodasAtividades(int idTurma)
        {
            List<Atividade> atividades = new List<Atividade>();
            Atividade atividade;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome FROM Atividade WHERE IdTurma = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@id", idTurma);


                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        atividade = new Atividade();
                        atividade.Id = Convert.ToInt32(rd["Id"]);
                        atividade.Nome = Convert.ToString(rd["Nome"]);
                        atividades.Add(atividade);

                    }
                }
                return atividades;

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
    }
}
