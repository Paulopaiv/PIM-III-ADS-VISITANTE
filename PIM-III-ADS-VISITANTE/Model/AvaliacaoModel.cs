
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

        internal void SalvarVoto()
        {
            string perguntaAtual = perguntas.PerguntaAtual();
            string avaliacaoAtual = avaliacao.AvaliacaoSelecionada();
            string codigoUsuario = pessoa.Codigo;

            if (perguntaAtual == "Obrigado por participar! Volte sempre.")
            {
                // Não salvar no banco
                return;
            }

            // Utiliza o código do usuário armazenado na classe estática
            avaliacaoService.RegistrarVoto(perguntaAtual, avaliacaoAtual, codigoUsuario);

            // Avança para a próxima pergunta
            perguntas.IndicePergunta++;
        }
    }
}
