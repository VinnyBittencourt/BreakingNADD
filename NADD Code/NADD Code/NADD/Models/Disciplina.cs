using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Disciplina 
    {
        public int DisciplinaId { get; set; }

        [Required(ErrorMessage = "Nome da disciplina é necessário")]
        [Display(Name = "Nome da Disciplina")]
        public string NomeDisciplina { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        //public ICollection<Professor> Professores { get; set; }

        //public int ProfessorId { get; set; }
        //public Professor Professor { get; set; }

        public ICollection<DisciplinaProfessor> DisciplinaProfessor { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }


        /* public Disciplina(int DisciplinaId, string NomeDisciplina, int CursoId)
        {
            this.DisciplinaId = DisciplinaId;
            this.NomeDisciplina = NomeDisciplina;
            this.CursoId = CursoId;
        } */

        public Disciplina()
        {
           
        }
    }
}
