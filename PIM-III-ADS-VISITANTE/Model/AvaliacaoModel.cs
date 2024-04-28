
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Servico;

namespace PIM_III_ADS_2P17_AVALIACAO.Modelo
{
    public class AvaliacaoModel
    {
        private AvaliacaoService avaliacaoService = new AvaliacaoService();
        private PerguntasControle perguntas;
        private AvaliacaoControle avaliacao;
        private PessoaControle pessoa;

        public AvaliacaoModel(PessoaControle pessoa,AvaliacaoControle avaliacao, PerguntasControle perguntas)
        {
            this.avaliacao = avaliacao;
            this.perguntas= perguntas;
            this.pessoa = pessoa;
        }

        internal void SalvarVoto()
        {
            string avaliacaoAtual = avaliacao.AvaliacaoSelecionada();
            string codigoUsuario = pessoa.Codigo;
            string perguntaAtual = perguntas.PerguntaAtual();

            if (perguntaAtual == "Obrigado por participar! Volte sempre.")
            {
                return;
            }

            avaliacaoService.RegistrarVoto(perguntaAtual, avaliacaoAtual, codigoUsuario);

            perguntas.IndicePergunta++;
        }
    }
}
