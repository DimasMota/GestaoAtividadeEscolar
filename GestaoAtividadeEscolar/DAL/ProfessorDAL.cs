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
        public Professor ValidarProfessor(string usuario, string senha)
        {
            Professor professor = new Professor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome FROM Professor WHERE Usuario = @Usuario AND Senha = @Senha";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Senha", senha);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        professor = new Professor();
                        professor.Id = Convert.ToInt32(rd["Id"]);
                        professor.Nome = Convert.ToString(rd["Nome"]);
                    }
                }
                return professor;

               
              


            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar validar professor no sistema ");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
