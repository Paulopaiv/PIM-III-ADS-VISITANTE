using PIM_III.View;
using PIM_III_ADS_2P17_AVALIACAO.Controle;

using PIM_III_ADS_2P17_AVALIACAO.Servico;
using static PIM_III_ADS_2P17_AVALIACAO.Controle.AvaliacaoControle;

namespace PIM_III_ADS_2P17_AVALIACAO.Modelo
{
    internal class AvaliacaoModel
    {
        private AvaliacaoService service = new AvaliacaoService();
        private PerguntasControle perguntas;
        private AvaliacaoControle avaliacao;

        public AvaliacaoModel(PerguntasControle perguntas, AvaliacaoControle avaliacao)
        {
            this.perguntas = perguntas;
            this.avaliacao = avaliacao;
        }

        internal AvaliacaoService AvaliacaoService
        {
            get => default;
            set
            {
            }
        }

        internal void RegistrarVoto()
        {
            // Obtém a pergunta atual
            string perguntaAtual = perguntas.ObterPerguntaAtual();

            if (perguntaAtual == "Obrigado por participar! Volte sempre.")
            {
                // Não salvar no banco
                return;
            }

            // Obtém a CheckBox selecionada pelo usuário
            CheckBox checkBoxSelecionado = avaliacao.CheckBoxSelecionado;

            if (checkBoxSelecionado == null)
            {
                Console.WriteLine("Nenhuma opção selecionada!");
                return;
            }

            // Obtém o texto da CheckBox selecionada
            string avaliacaoSelecionada = checkBoxSelecionado.Text;

            // Utiliza o código do usuário armazenado na classe estática
            service.RegistrarVoto(perguntaAtual, avaliacaoSelecionada, AvaliacaoControle.UsuarioLogado.Codigo);

            // Avança para a próxima pergunta
            perguntas.IndicePergunta++;
        }

    }
}
