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
        public ProfessorModels BuscarVerificarUsuarioSenha(string usuario, string senha)
        {
           

            return new ProfessorDAL().BuscarVerificarUsuarioSenha(usuario, senha);
            
        }
    }
}
