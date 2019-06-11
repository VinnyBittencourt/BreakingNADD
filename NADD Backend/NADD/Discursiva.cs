using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    public class Discursiva : IQuestao
    {
        private double valor;
        private string tipo;
        private string observacao;

        public Discursiva(double valor, string tipo, string observacao)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.observacao = observacao;
        }

        public override void VerificaPontuacao()
        {
            Console.WriteLine("Entrou no VerificaPontuacao");
        }
        public override void VerificaClareza()
        {
            Console.WriteLine("Entrou no VerificaClareza");
        }
    }
}
