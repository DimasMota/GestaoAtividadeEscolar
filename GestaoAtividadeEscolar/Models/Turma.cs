using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    
        public List<Atividade> Atividades { get; set; }

        public Turma()
        {
            Atividades = new List<Atividade>();
        }
    }
}
