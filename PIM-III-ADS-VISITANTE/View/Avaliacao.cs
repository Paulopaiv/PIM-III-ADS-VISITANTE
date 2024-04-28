
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Modelo;


namespace PIM_III.View
{
    public partial class Avaliacao : Form
    {
        private AvaliacaoControle avaliacaoControle;
        private PerguntasControle perguntasControle;
        private AvaliacaoModel avaliacaoModel;
        private PessoaControle pessoa;

        public Avaliacao(PessoaControle pessoa)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.pessoa = pessoa;
            avaliacaoControle = new AvaliacaoControle();
            perguntasControle = new PerguntasControle(pnlAvaliacao);
            avaliacaoModel = new AvaliacaoModel(pessoa, avaliacaoControle, perguntasControle);
            AtualizarPergunta();
        }

        private void AtualizarPergunta()
        {
            lblPergunta.Text = perguntasControle.PerguntaAtual();
            lblPergunta.MaximumSize = new Size(1200, 0);
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;  
            int topPosition = (int)(7 * CreateGraphics().DpiY / 2.54);
            int leftPosition = (this.ClientSize.Width - lblPergunta.Width) / 2;
            lblPergunta.Location = new Point(leftPosition, topPosition);
        }

        private void btnRuim_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Ruim = true;
            avaliacaoControle.Regular = false;
            avaliacaoControle.Bom = false;
            avaliacaoControle.Otimo = false;
            avaliacaoControle.Excelente = false;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Regular = true;
            avaliacaoControle.Ruim = false;
            avaliacaoControle.Bom = false;
            avaliacaoControle.Otimo = false;
            avaliacaoControle.Excelente = false;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }

        private void btnBom_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Bom = true;
            avaliacaoControle.Ruim = false;
            avaliacaoControle.Regular = false;
            avaliacaoControle.Otimo = false;
            avaliacaoControle.Excelente = false;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }

        private void btnOtimo_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Otimo = true;
            avaliacaoControle.Ruim = false;
            avaliacaoControle.Regular = false;
            avaliacaoControle.Bom = false;
            avaliacaoControle.Excelente = false;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }

        private void btnExcelente_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Excelente = true;
            avaliacaoControle.Ruim = false;
            avaliacaoControle.Regular = false;
            avaliacaoControle.Bom = false;
            avaliacaoControle.Otimo = false;
            avaliacaoModel.SalvarVoto();
            AtualizarPergunta();
        }
    }
}
