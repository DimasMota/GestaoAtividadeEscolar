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
        public List<AtividadeModels> BuscarTodasAtividades(int idTurma)
        {
            List<AtividadeModels> atividades = new List<AtividadeModels>();
            atividades = new AtividadeDAL().BuscarTodasAtividades(idTurma);
            if (atividades.Count() < 1)
            {
                throw new Exception("Não tem atividades cadastradas");
            }
            return atividades;
        }
        public void Cadastrar(AtividadeModels atividade, int idTurma)
        {
           
          new AtividadeDAL().Cadastrar(atividade,idTurma);
           
        }
    }
}
