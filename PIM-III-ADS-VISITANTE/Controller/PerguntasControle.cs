using WinFormsTimer = System.Windows.Forms.Timer;

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    public class PerguntasControle
    {
        private System.Windows.Forms.Timer timer;
        private AvaliacaoControle avaliacaoControle;
        private int indicePergunta = 0;
        private Label label;
        private GroupBox gpbAvaliacao;
        private string[] perguntas = {

             "Como você avaliaria a clareza das instruções fornecidas para interagir com as exposições?",
             "Em sua opinião, como as tecnologias utilizadas nas exposições contribuíram para a sua compreensão dos temas abordados?",
             "Como você classificaria a interatividade das exposições?",
             "Considerando sua visita ao museu, como você classificaria sua satisfação geral?",
             "Como você avalia a facilidade de uso do sistema dos totens para interagir com as exposições?"
        };

        public PerguntasControle(AvaliacaoControle avaliacaoControle, GroupBox gpbAvaliacao)
        {
            this.avaliacaoControle = avaliacaoControle;
            this.gpbAvaliacao = gpbAvaliacao; // Armazene a referência ao GroupBox

            // Instancie o Label
            this.label = new Label();
            // Adicione o Label ao GroupBox
            this.gpbAvaliacao.Controls.Add(this.label);

            // Inicialize o temporizador
            timer = new WinFormsTimer();
            timer.Interval = 2000; // Defina o intervalo do temporizador para 2 segundos
            timer.Tick += Timer_Tick; // Adicione um manipulador de eventos para o evento Tick do temporizador
        }

        public string ObterPerguntaAtual()
        {
            if (indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                OcultarGroupBox();
                timer.Start();
                return "Obrigado por participar! Volte sempre.";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Pare o temporizador
            timer.Stop();

            // Feche a página
            ((Form)gpbAvaliacao.Parent).Close();
        }

        private void OcultarGroupBox()
        {
            // Oculta o GroupBox
            if (gpbAvaliacao.InvokeRequired)
            {
                gpbAvaliacao.Invoke(new MethodInvoker(() => gpbAvaliacao.Visible = false));
            }
            else
            {
                gpbAvaliacao.Visible = false;
            }
        }

        public void LimparSelecaoCheckBox(Control.ControlCollection controles)
        {
            // Desmarca explicitamente todos os CheckBoxes
            foreach (Control control in controles)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
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

        public AvaliacaoControle AvaliacaoControle // Propriedade para acessar a classe AvaliacaoControle
        {
            get { return avaliacaoControle; }
        }

        internal Modelo.AvaliacaoModel AvaliacaoModel
        {
            get => default;
            set
            {
            }
        }
    }
}
