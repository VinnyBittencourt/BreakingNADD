using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Professor
    {
        private int idProfessor;
        private string nomeProfessor;
        private string emailProfessor;
        private string telProfessor;
        private string cpfProfessor;

        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
        public string NomeProfessor { get => nomeProfessor; set => nomeProfessor = value; }
        public string EmailProfessor { get => emailProfessor; set => emailProfessor = value; }
        public string TelProfessor { get => telProfessor; set => telProfessor = value; }
        public string CpfProfessor { get => cpfProfessor; set => cpfProfessor = value; }

        public Professor(int idProfessor, string nomeProfessor, string emailProfessor, string telProfessor, string cpfProfessor)
        {
            this.IdProfessor = idProfessor;
            this.NomeProfessor = nomeProfessor;
            this.EmailProfessor = emailProfessor;
            this.TelProfessor = telProfessor;
            this.CpfProfessor = cpfProfessor;
        }
    }
}
