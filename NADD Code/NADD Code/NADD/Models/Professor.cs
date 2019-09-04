using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string NomeProfessor { get; set; }
        public string EmailProfessor { get; set; }
        public string TelProfessor { get; set; }
        public string CpfProfessor { get; set; }

        //public int DisciplinaId { get; set; }
        //public Disciplina Disciplina { get; set; }

        //public ICollection<Disciplina> Disciplinas { get; set; }

        public ICollection<DisciplinaProfessor> DisciplinaProfessor { get; set; }


        private int idProfessor;

        public Professor(int idProfessor, string nomeProfessor, string emailProfessor, string telProfessor, string cpfProfessor)
        {
            this.ProfessorId = idProfessor;
            this.NomeProfessor = nomeProfessor;
            this.EmailProfessor = emailProfessor;
            this.TelProfessor = telProfessor;
            this.CpfProfessor = cpfProfessor;
        }
    }
}
