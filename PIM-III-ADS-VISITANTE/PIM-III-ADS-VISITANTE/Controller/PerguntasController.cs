using PIM_III_ADS_VISITANTE.Model;
using PIM_III_ADS_VISITANTE.View;
using System;
using System.Windows.Forms;

namespace PIM_III_ADS_VISITANTE.Controller
{
    public class PerguntasController
    {
        private Obrigado obrigado;
        private MediaAvaliacaoModel media;
        private Panel pnlAvaliacao;
        private int indicePergunta = 0;
        private string[] perguntas = {
            "Como você avaliaria a clareza das instruções fornecidas para interagir com as exposições?",
            "Em sua opinião, como as tecnologias utilizadas nas exposições contribuíram para a sua compreensão dos temas abordados?",
            "Como você classificaria a interatividade das exposições?",
            "Considerando sua visita ao museu, como você classificaria sua satisfação geral?",
            "Como você avalia a facilidade de uso do sistema dos totens para interagir com as exposições?"
        };

        public PerguntasController(Panel pnlAvaliacao)
        {
            this.pnlAvaliacao = pnlAvaliacao; // Armazene a referência ao Panel

            obrigado = new Obrigado();
            media = new MediaAvaliacaoModel();

            // Adicione um manipulador de eventos para sinalizar a conclusão das avaliações
            media.AvaliacoesConcluidas += Media_AvaliacoesConcluidas;
        }

        public string PerguntaAtual()
        {
            if (indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                // Exibindo a tela de agradecimento e finalizando a avaliação
                pnlAvaliacao.Visible = false;
                obrigado.Show();
                media.CalcularMediaAvaliacoes(); // Calcular a média das avaliações
                return "";
            }
        }

        private void Media_AvaliacoesConcluidas(object sender, EventArgs e)
        {
            // Encontrar a instância correta de Obrigado
            Obrigado obrigadoForm = (Obrigado)Application.OpenForms.OfType<Obrigado>().FirstOrDefault();

            if (obrigadoForm != null)
            {
                obrigadoForm.SetMediaAvaliacao(media);
            }
        }




        public string[] Perguntas
        {
            get { return perguntas; }
            set { perguntas = value; }
        }

        public int IndicePergunta
        {
            get { return indicePergunta; }
            set { indicePergunta = value; }
        }
    }
}
