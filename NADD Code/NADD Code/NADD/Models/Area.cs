using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Area
    {
        public int AreaId { get; set; }

        [Required(ErrorMessage = "Nome da área é necessário")]
        [Display(Name="Nome da Area")]
        public string NomeArea { get; set; }

        public ICollection<Curso> Curso{ get; set; }

        /*public Area(int AreaId, string nomeArea)
        {
            this.AreaId = AreaId;
            this.NomeArea = nomeArea;
        }*/

    }
}
