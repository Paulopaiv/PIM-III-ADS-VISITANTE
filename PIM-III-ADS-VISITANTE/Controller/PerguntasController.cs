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

            this.pnlAvaliacao = pnlAvaliacao; // Armazene a referência ao GroupBox

            obrigado = new Obrigado();
            // Inicialize o temporizador
            timer = new WinFormsTimer();
            timer.Interval = 4000; // Defina o intervalo do temporizador para 2 segundos
            timer.Tick += Timer_Tick; // Adicione um manipulador de eventos para o evento Tick do temporizador
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
