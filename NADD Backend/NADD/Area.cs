using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Area
    {
        private int idArea;
        private string nomeArea;

        public Area(int idArea, string nomeArea)
        {
            this.IdArea = idArea;
            this.NomeArea = nomeArea;
        }

        public int IdArea { get => idArea; set => idArea = value; }
        public string NomeArea { get => nomeArea; set => nomeArea = value; }
    }
}
