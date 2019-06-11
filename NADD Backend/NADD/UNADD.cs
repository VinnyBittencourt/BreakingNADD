using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public class UNADD : Usuario
    {
        public UNADD(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario) : base(idUsuario, nomeUsuario, emailUsuario, senhaUsuario) { }
        public override void cadastrarArea()
        {
            Console.WriteLine("Área enviada para avaliação do reitor, se aceita, a Área será cadastrada.");
        }
    }
}
