using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProfessorModels
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public List<TurmaModels> Turmas { get; set; }

        public ProfessorModels()
        {
            Turmas = new List<TurmaModels>();
        }
    }
}
