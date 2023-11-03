using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TurmaBLL
    {
        public List<TurmaModels> BuscarTodasTurma(int id)
        {
            List<TurmaModels> turmas = new List<TurmaModels>();
            turmas = new TurmaDAL().BuscarTodasTurma(id);
                if(turmas.Count() < 1)
            {
                throw new Exception("Não tem turmas cadastradas");
            }
            return turmas;
        }

        public void Cadastrar(TurmaModels turma, int idProfessor)
        {
            new TurmaDAL().Cadastrar(turma,idProfessor);

        }

        public void Excluir(int id)
        {
            new TurmaDAL().Excluir(id);
        }
    }
}
