using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Curso
    {
        private int idCurso;
        private string nomeCurso;
        private Area idArea;

        public Curso(int idCurso, string nomeCurso, Area idArea)
        {
            this.IdCurso = idCurso;
            this.NomeCurso = nomeCurso;
            this.IdArea = idArea;
        }

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string NomeCurso { get => nomeCurso; set => nomeCurso = value; }
        internal Area IdArea { get => idArea; set => idArea = value; }
    }
}
