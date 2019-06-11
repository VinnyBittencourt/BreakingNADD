using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public class Reitoria : Usuario
    {
        public Reitoria(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario) : base(idUsuario, nomeUsuario, emailUsuario, senhaUsuario) { }

        public override void cadastrarArea()
        {
            Console.WriteLine("Área Cadastrada com Sucesso!");
        }

    }
    
}
