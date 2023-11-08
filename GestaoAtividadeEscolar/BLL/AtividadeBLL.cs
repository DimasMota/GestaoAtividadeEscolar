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
        public void Cadastrar(Atividade atividade, int idTurma)
        {
            new AtividadeDAL().Cadastrar(atividade, idTurma);
        }
        public List<Atividade> BuscarTodasAtividades(int idTurma)
        {
            return new AtividadeDAL().BuscarTodasAtividades(idTurma);
        }
    }
}
