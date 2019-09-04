using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }

        [Required]
        public string NomeProfessor { get; set; }

        [Required]
        public string EmailProfessor { get; set; }

        [Required]
        public string TelProfessor { get; set; }

        [Required]
        public string CpfProfessor { get; set; }

        //public int DisciplinaId { get; set; }
        //public Disciplina Disciplina { get; set; }

        //public ICollection<Disciplina> Disciplinas { get; set; }

        public ICollection<DisciplinaProfessor> DisciplinaProfessor { get; set; }



        /*public Professor( string nomeProfessor, string emailProfessor, string telProfessor, string cpfProfessor)
        {
 
            this.NomeProfessor = nomeProfessor;
            this.EmailProfessor = emailProfessor;
            this.TelProfessor = telProfessor;
            this.CpfProfessor = cpfProfessor;
        } */

        public Professor()
        {

        }
    }
}
