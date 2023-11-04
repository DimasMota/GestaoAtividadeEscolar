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
        public Professor ValidarUsuarioSenha(string _usuario, string _senha)
        {
            Professor professor = new Professor();

            professor = new ProfessorDAL().ValidarUsuarioSenha(_usuario, _senha);

            if(String.IsNullOrEmpty(professor.Nome))
            {
                throw new Exception("Senha ou Usuário inválido");
            }
            return professor;

        }
    }
}
