using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AtividadeBLL
    {
        public List<Atividade> BuscarTodasAtividades(int idTurma)
        {
            List<Atividade> atividades = new List<Atividade>();
            atividades = new AtividadeDAL().BuscarTodasAtividades(idTurma);
            if (atividades.Count() < 0)
            {
                throw new Exception("Não tem turma cadastradas");
            }
            return atividades;
        }
        public void Cadastrar(Atividade atividade, int idTurma)
        {
            new AtividadeDAL().Cadastrar(atividade, idTurma);
        }
    }
}
