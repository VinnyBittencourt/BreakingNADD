using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage ="Use menos caracteres.")]
        public String NomeCurso { get; set; }

        //internal Area AreaId { get; set; }

        //public ICollection<Area> Area { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }




        public Curso(int CursoId, string nomeCurso, Area idArea)
        {
            this.CursoId = CursoId;
            this.NomeCurso = nomeCurso;
            this.AreaId = idArea;
        }

    }
}

