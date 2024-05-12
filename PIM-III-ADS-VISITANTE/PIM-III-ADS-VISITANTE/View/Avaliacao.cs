using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace PIM_III_ADS_VISITANTE.View
{
    public partial class Avaliacao : Form
    {
        public AvaliacaoController avaliacaoControle;
        public PerguntasController perguntasControle;
        public AvaliacaoModel avaliacaoModel;
        public PessoaController pessoa;
        private WinFormsTimer timer;
      
        public Avaliacao(PessoaController pessoa)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.pessoa = pessoa;
            avaliacaoControle = new AvaliacaoController();
            perguntasControle = new PerguntasController(pnlAvaliacao);
            avaliacaoModel = new AvaliacaoModel(pessoa, avaliacaoControle, perguntasControle);

            timer = new WinFormsTimer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;

            timer.Start();
            AtualizarPergunta();
        }

        public void AtualizarPergunta()
        {
            lblPergunta.Text = perguntasControle.PerguntaAtual();
            lblPergunta.MaximumSize = new Size(1200, 0);
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            int topPosition = (int)(15 * CreateGraphics().DpiY / 4);
            int leftPosition = (this.ClientSize.Width - lblPergunta.Width) / 2;
            lblPergunta.Location = new Point(leftPosition, topPosition);
        }

        public void btnRuim_Click(object sender, EventArgs e)
        {
            SetAvaliacao(true, false, false, false, false);
        }

        public void btnRegular_Click(object sender, EventArgs e)
        {
            SetAvaliacao(false, true, false, false, false);
        }

        public void btnBom_Click(object sender, EventArgs e)
        {
            SetAvaliacao(false, false, true, false, false);
        }

        public void btnOtimo_Click(object sender, EventArgs e)
        {
            SetAvaliacao(false, false, false, true, false);
        }

        public void btnExcelente_Click(object sender, EventArgs e)
        {
            SetAvaliacao(false, false, false, false, true);
        }

        private void SetAvaliacao(bool ruim, bool regular, bool bom, bool otimo, bool excelente)
        {
            avaliacaoControle.Ruim = ruim;
            avaliacaoControle.Regular = regular;
            avaliacaoControle.Bom = bom;
            avaliacaoControle.Otimo = otimo;
            avaliacaoControle.Excelente = excelente;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            timer.Stop();
        }

    }
}
