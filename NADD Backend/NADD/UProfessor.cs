using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public class UProfessor : Usuario , IAlerta
    {
        public UProfessor(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario) : base(idUsuario, nomeUsuario, emailUsuario, senhaUsuario) { }

        public override void cadastrarArea()
        {
            Console.WriteLine("Você não pode cadastrar uma Área");
        }

        public string alertaNovaAvaliacao()
        {
            return "Você possui uma nova Avaliação!";
        }
    }

    
}
