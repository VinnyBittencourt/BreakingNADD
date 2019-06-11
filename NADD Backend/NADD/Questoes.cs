using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Questoes : FabricaQuestoes
    {
        private double _valor;
        private string _tipo;
        private string _observacao;

        public Questoes(double valor, string tipo, string observacao)
        {
            Valor = valor;
            Tipo = tipo;
            Observacao = observacao;
        }

        public double Valor { get => _valor; set => _valor = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }

        public override IQuestao criarQuestao()
        {
            if (Tipo.Equals("Objetiva"))
            {
                return new Objetiva(Valor, Tipo, Observacao);
            }
            else
            {
                return new Discursiva(Valor, Tipo, Observacao);
            }
        }
    }
}
