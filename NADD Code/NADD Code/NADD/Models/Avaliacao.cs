using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Avaliacao
    {
        public int AvaliacaoId { get; set; }

        [Required(ErrorMessage = "Nome do avaliador é necessário")]
        [Display(Name="Nome do Avaliador")]
        public string NomeAvaliador { get; set; }

        //[Required(ErrorMessage = "Email do avalidor é necessário")]
        //[Display(Name = "Email do Avaliador")]
        //public string Email { get; set; }

        [Display(Name = "Nome do Avaliador")] 
        public int ProfessorId { get; set; }
        //public Professor Professors { get; set; }

        [Required(ErrorMessage = "Horário de ínicio é necessário")]
        [Display(Name = "Horario de Início")]
        public DateTime HoraInicio { get; set; }

        [Required(ErrorMessage = "Horário de conclusão é necessário")]
        [Display(Name = "Horario de conclusão")]
        public DateTime HoraConclusao { get; set; }

        [Required(ErrorMessage = "Valor da prova explícito é necessário")]
        [Display(Name = "Valor da prova explícito")]
        public int ValorProvaExp { get; set; }


        //Mudar
        [Required(ErrorMessage = "Valor das questões explícitos é necessário")]
        [Display(Name = "Valor das questões explícitos")]
        public int ValorQuestExp { get; set; }

        //[Display(Name = "Questões explícitas")]
        //List<string> QuestoesExpl = new List<string>();

        //Somatório


        [Display(Name = "Referências Bibliográficas")]
        public string RefBibliograficas { get; set; }

        [Required(ErrorMessage = "Possui questões de múltipla escolha e discursiva?")]
        [Display(Name = "Possui questões de múltipla escolha e discursiva?")]
        public string PQuestMultdisc { get; set; }

        [Required(ErrorMessage = "Este campo é necessário")]
        [Display(Name = "Equilíbrio nas distribuições dos valores das questões")]
        public string Eqdistvquest { get; set; }

        //Adicionado
        //[Required(ErrorMessage = "Este campo é necessário")]
        //[Display(Name = "Apresenta, explicitamente, diversificação na avaliação?")]
        //public string Aprexplcdiversao { get; set; }

        [Required(ErrorMessage = "Este campo é necessário")]
        [Display(Name = "A prova possui, pelo menos, uma questão contextualizada?")]
        public string Ppquestcontext { get; set; }

        
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Este campo é necessário")]
        [Display(Name = "Quantidade de Questões")]
        public int QtyQuestoes { get; set; }

        [Required(ErrorMessage = "Este campo é necessário")]
        [Display(Name = "Média")]
        public double Media { get; set; }

        [Required(ErrorMessage = "Este campo é necessário")]
        [Display(Name = "Valor Total da Prova")]
        public double TotValor { get; set; }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplinas { get; set; }

        //public int? CursoId { get; set; }
        //public Curso Cursod { get; set; }

        public ICollection<Questoes> Questoes { get; set; }

        static int TotAvaliacao;


        /*public Avaliacao(string nomeAvaliador, string email, DateTime horaConclusao, int valorProvaExp, int valorQuestExp, string refBibliograficas, string pQuestMultdisc, string eqdistvquest, string ppquestcontext, string observacao)
        {
            AvaliacaoId = TotAvaliacao++;
            QtyQuestoes = 0;
            NomeAvaliador = nomeAvaliador;
            Email = email;
            HoraInicio = DateTime.Now;
            HoraConclusao = horaConclusao;
            ValorProvaExp = valorProvaExp;
            ValorQuestExp = valorQuestExp;
            RefBibliograficas = refBibliograficas;
            PQuestMultdisc = pQuestMultdisc;
            Eqdistvquest = eqdistvquest;
            Ppquestcontext = ppquestcontext;
            Observacao = observacao;
            TotValor = 0;
        }

        public Avaliacao()
        {
            AvaliacaoId = TotAvaliacao++;
            HoraInicio = DateTime.Now;
            QtyQuestoes = 0;
            TotValor = 0;
        } */

        public Avaliacao()
        {

        }



        internal List<Questoes> VetQuest { get; set; }

        public void NovaQuestao(double valor, string tipo, string observacao)
        {
            Questoes questao = new Questoes(valor, tipo, observacao);
            VetQuest.Add(questao);
            QtyQuestoes += 1;
            ValorTotal();
            MediaAvaliacao();
        }

        public double ValorTotal()
        {
            TotValor += VetQuest[(QtyQuestoes - 1)].Valor;

            return TotValor;
        }

        public double MediaAvaliacao()
        {
            Media = TotValor / QtyQuestoes;

            return Media;
        }

    }
}
