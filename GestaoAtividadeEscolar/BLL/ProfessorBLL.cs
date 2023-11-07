using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProfessorBLL
    {
        public Professor ValidarProfessor(string usuario, string senha)
        {
            return new ProfessorDAL().ValidarProfessor(usuario, senha);
        }
    }
}
