using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public class Objetiva : IQuestao
    {
        private double valor;
        private string tipo;
        private string observacao;

        public Objetiva(double valor, string tipo, string observacao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.observacao = observacao;
        }

        public override void VerificaPontuacao()
        {
            Console.WriteLine("VerificaPontuacao");
        }
        public override void VerificaClareza()
        {
            Console.WriteLine("VerificaClareza");
        }
    }
}
