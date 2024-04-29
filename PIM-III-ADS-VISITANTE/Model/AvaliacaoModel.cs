using PIM_III_ADS_2P17_AVALIACAO.Servico;
using PIM_III_ADS_VISITANTE.Model;

namespace PIM_III_ADS_VISITANTE.Controller
{
    public class AvaliacaoModel
    {
        private AvaliacaoService avaliacaoService = new AvaliacaoService();
        private PerguntasController perguntas;
        private AvaliacaoController avaliacao;
        private PessoaController pessoa;

        public AvaliacaoModel(PessoaController pessoa, AvaliacaoController avaliacao, PerguntasController perguntas)
        {
            this.avaliacao = avaliacao;
            this.perguntas = perguntas;
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
