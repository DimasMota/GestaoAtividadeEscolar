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
        public List<AtividadeModels> BuscarTodasAtividades(int idturma)
        {

            List<AtividadeModels> atividades = new List<AtividadeModels>();

            AtividadeModels atividade;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT A.Id, A.Descricao FROM Turma T INNER JOIN Atividade A ON T.Id = A.IdTurma WHERE T.Id = @id ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@id", idturma);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        atividade = new AtividadeModels();
                        atividade.Id = Convert.ToInt32(rd["Id"]);
                        atividade.Descricao = Convert.ToString(rd["Descricao"]);
                        atividades.Add(atividade);
                    }
                }
                return atividades;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar Buscar uma atividade no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Cadastrar(AtividadeModels atividade, int idTurma)
        {
           
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Atividade (IdTurma, Descricao) VALUES(@IdTurma, @Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", atividade.Descricao);
                cmd.Parameters.AddWithValue("@IdTurma", idTurma);



                cn.Open();
                cmd.ExecuteNonQuery();
              
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
    }
}
