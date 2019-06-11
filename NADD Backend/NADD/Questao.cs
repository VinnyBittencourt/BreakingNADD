using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NADD
{
    class Questao
    {
        private int idQuestao;
        private string resultado;
        private string observacao;
        private Avaliacao avaliacao;

        public int IdQuestao { get => idQuestao; set => idQuestao = value; }
        public string Resultado { get => resultado; set => resultado = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        internal Avaliacao Avaliacao { get => avaliacao; set => avaliacao = value; }

        public Questao(int idQuestao, string resultado, string observacao, Avaliacao avaliacao)
        {
            this.IdQuestao = idQuestao;
            this.Resultado = resultado;
            this.Observacao = observacao;
            this.Avaliacao = avaliacao;
        }
    }
}
