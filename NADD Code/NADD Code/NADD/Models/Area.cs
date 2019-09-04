using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string NomeArea { get; set; }

        public ICollection<Curso> Curso{ get; set; }

        public Area(int AreaId, string nomeArea)
        {
            this.AreaId = AreaId;
            this.NomeArea = nomeArea;
        }

    }
}
