using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public abstract class Usuario
    {
        
        private int idUsuario;
        private string nomeUsuario;
        private string emailUsuario;
        private string senhaUsuario;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }

        public Usuario(int idUsuario, string nomeUsuario, string emailUsuario, string senhaUsuario)
        {
            this.IdUsuario = idUsuario;
            this.NomeUsuario = nomeUsuario;
            this.EmailUsuario = emailUsuario;
            this.SenhaUsuario = senhaUsuario;
        }
        public Usuario()
        {

        }

        public Usuario(int idUsuario, string nomeUsuario)
        {
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
        }
        public virtual void cadastrarArea()
        {
        }

    }
}
