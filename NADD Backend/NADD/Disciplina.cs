using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Disciplina
    {
        private int idDisciplina;
        private string nomeDisciplina;
        private Curso curso;

        public Disciplina(int idDisciplina, string nomeDisciplina, Curso curso)
        {
            this.IdDisciplina = idDisciplina;
            this.NomeDisciplina = nomeDisciplina;
            this.Curso = curso;
        }

        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
        public string NomeDisciplina { get => nomeDisciplina; set => nomeDisciplina = value; }
        internal Curso Curso { get => curso; set => curso = value; }
    }
}
