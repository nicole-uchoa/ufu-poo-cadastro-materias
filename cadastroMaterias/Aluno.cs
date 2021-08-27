using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroMaterias
{
    class Aluno
    {
        public string Nome { get; set; }

        public List<String> Materias { get; set; }

        public Aluno()
        {
            Materias = new List<string>();
        }

    }
}
