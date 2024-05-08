using PIM_III_ADS_VISITANTE.Model;

using PIM_III_ADS_VISITANTE.View;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace PIM_III_ADS_VISITANTE.Controller
{
    public class PerguntasController
    {
        private Obrigado obrigado;
        private WinFormsTimer timer;
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
            this.pnlAvaliacao = pnlAvaliacao; 
            obrigado = new Obrigado();
            timer = new WinFormsTimer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick; 
        }

        public string PerguntaAtual()
        {
            if (indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                pnlAvaliacao.Visible = false;
                timer.Start();

                obrigado.Show();

                return "";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            timer.Stop();






            // Dentro de algum lugar onde você quer exibir os resultados
            MediaAvaliacaoModel mediaAvaliacaoModel = new MediaAvaliacaoModel();
            mediaAvaliacaoModel.ExibirMediaAvaliacoes();








            ((Form)pnlAvaliacao.Parent).Close();
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
