using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Disciplina 
    {
        public int DisciplinaId { get; set; }
        public string NomeDisciplina { get; set; }

        internal Curso Curso { get; set; }


        public Disciplina(int DisciplinaId, string nomeDisciplina, Curso curso)
        {
            this.DisciplinaId = DisciplinaId;
            this.NomeDisciplina = nomeDisciplina;
            this.Curso = curso;
        }
    }
}
