using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Questoes
    {
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public string Observacao { get; set; }


        public Questoes(double valor, string tipo, string observacao)
        {
            Valor = valor;
            Tipo = tipo;
            Observacao = observacao;
        }
    }
}
