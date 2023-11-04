using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TurmaBLL
    {
        public List<Turma> BuscarTodasTurmas(int idProfessor)
        {
            List<Turma> turmas = new List<Turma>();
            turmas = new TurmaDAL().BuscarTodasTurmas(idProfessor);
            if (turmas.Count() < 0)
            {
                throw new Exception("Não tem turma cadastradas");
            }
            return turmas;
        }
        public void Cadastrar(Turma turma)
        {
            new TurmaDAL().Cadastrar(turma);
        }
        public bool VerificarVinculoAtividade(int idTurma)
        {
            return new TurmaDAL().VerificarVinculoAtividade(idTurma);
        }
        public void Excluir(int idTurma)
        {
            new TurmaDAL().Excluir(idTurma);
        }
    }
}
