using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessorBLL
    {
        public ProfessorModels BuscarProfessorPorId(int idUsuarioLogado)
        {
            return new ProfessorDAL().BuscarProfessorPorId(idUsuarioLogado);
        }

        public ProfessorModels BuscarVerificarUsuarioSenha(string usuario, string senha)
        {

            try
            {

            return new ProfessorDAL().BuscarVerificarUsuarioSenha(usuario, senha);
            }
            catch (Exception  ex)
            {

                throw;
            }
            
        }
    }
}
