using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;


namespace PIM_III.View
{
    public partial class Avaliacao : Form
    {
        private AvaliacaoController avaliacaoControle;
        private PerguntasController perguntasControle;
        private AvaliacaoModel avaliacaoModel;
        private PessoaController pessoa;

        public Avaliacao(PessoaController pessoa)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.pessoa = pessoa;
            avaliacaoControle = new AvaliacaoController();
            perguntasControle = new PerguntasController(pnlAvaliacao);
            avaliacaoModel = new AvaliacaoModel(pessoa, avaliacaoControle, perguntasControle);
            AtualizarPergunta();
        }

        private void AtualizarPergunta()
        {
            lblPergunta.Text = perguntasControle.PerguntaAtual();
            lblPergunta.MaximumSize = new Size(1200, 0);
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            int topPosition = (int)(15 * CreateGraphics().DpiY / 4);
            int leftPosition = (this.ClientSize.Width - lblPergunta.Width) / 2;
            lblPergunta.Location = new Point(leftPosition, topPosition);
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            bool ruim = false, regular = false, bom = false, otimo = false, excelente = false;
            switch (clickedButton.Name)
            {
                case "btnRuim":
                    ruim = true;
                    break;
                case "btnRegular":
                    regular = true;
                    break;
                case "btnBom":
                    bom = true;
                    break;
                case "btnOtimo":
                    otimo = true;
                    break;
                case "btnExcelente":
                    excelente = true;
                    break;
                default:
                    break;
            }

            AtualizarAvaliacao(ruim, regular, bom, otimo, excelente);
        }

        private void AtualizarAvaliacao(bool ruim, bool regular, bool bom, bool otimo, bool excelente)
        {
            avaliacaoControle.Ruim = ruim;
            avaliacaoControle.Regular = regular;
            avaliacaoControle.Bom = bom;
            avaliacaoControle.Otimo = otimo;
            avaliacaoControle.Excelente = excelente;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }

    }
}
