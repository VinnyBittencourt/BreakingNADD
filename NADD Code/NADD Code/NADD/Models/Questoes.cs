using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Questoes
    {
        public int QuestoesId { get; set; }
        [Required(ErrorMessage = "Número questão é necessário")]
        [Display(Name = "Numero da Questão")]
        public string NumeroQuestao { get; set; }
        [Required(ErrorMessage = "Valor questão é necessário")]
        [Display(Name = "Valor da Questão")]
        public double Valor { get; set; }
        [Display(Name = "Tipo de Questão")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Precisa de uma observação ou opnião sobre a questão")]
        [Display(Name = "Observação da Questão")]
        public string Observacao { get; set; }
        [Display(Name = "Questão Contextualizada?")]
        public string Contextualizada { get; set; }
        [Display(Name = "Questão possui Clareza?")]
        public string Clareza { get; set; }
        [Display(Name = "Questão possui Complexibilidade?")]
        public string Complexibilidade { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        public int AvaliacaoId { get; set; }
        [Display(Name = "Avaliacao")]
        public Avaliacao Avaliacao { get; set; }

        /*public Questoes(double valor, string tipo, string observacao)
        {
            Valor = valor;
            Tipo = tipo;
            Observacao = observacao;
        }*/

        public Questoes()
        {

        }
    }
}
