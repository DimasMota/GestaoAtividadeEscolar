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
        public Professor ValidarUsuarioSenha(string _usuario, string _senha)
        {
            Professor professor = new Professor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"SELECT Id, Nome, Usuario, Senha FROM Professor WHERE Senha = @Senha AND Usuario = @Usuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Senha", _senha);
                cmd.Parameters.AddWithValue("@Usuario", _usuario);

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

                throw new Exception("Erro ao tentar acessar o banco de dados",ex);
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
