using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NADD.Models
{
    public class Avaliacao
    {
        public int AvaliacaoId { get; set; }
        public string NomeAvaliador { get; set; }
        public string Email { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraConclusao { get; set; }
        public int ValorProvaExp { get; set; }
        public int ValorQuestExp { get; set; }
        public string RefBibliograficas { get; set; }
        public string PQuestMultdisc { get; set; }
        public string Eqdistvquest { get; set; }
        public string Ppquestcontext { get; set; }
        public string Observacao { get; set; }
        public int QtyQuestoes { get; set; }
        public double Media { get; set; }
        public double TotValor { get; set; }

        public int DisciplinaId { get; set; }
        public Disciplina Disciplinas { get; set; }

        public ICollection<Questoes> Questoes { get; set; }

        static int TotAvaliacao;


        public Avaliacao(string nomeAvaliador, string email, DateTime horaConclusao, int valorProvaExp, int valorQuestExp, string refBibliograficas, string pQuestMultdisc, string eqdistvquest, string ppquestcontext, string observacao, Disciplina disciplina)
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
            Disciplina = disciplina;
            TotValor = 0;
        }

        public Avaliacao()
        {
            AvaliacaoId = TotAvaliacao++;
            HoraInicio = DateTime.Now;
            QtyQuestoes = 0;
            TotValor = 0;
        }


        internal Disciplina Disciplina { get; set; }
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
