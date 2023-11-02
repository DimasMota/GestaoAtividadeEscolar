using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TurmaModels
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<AtividadeModels> Atividades { get; set; }

        public TurmaModels() {
            Atividades = new List<AtividadeModels>();
        }

    }
}
