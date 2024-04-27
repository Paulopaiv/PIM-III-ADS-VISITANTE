
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PIM_III.View
{
    public partial class Avaliacao : Form
    {
        private AvaliacaoControle avaliacaoControle;
        private PerguntasControle perguntasControle;
        private AvaliacaoModel avaliacaoModel;

        public Avaliacao()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            avaliacaoControle = new AvaliacaoControle();
            perguntasControle = new PerguntasControle();
            avaliacaoModel = new AvaliacaoModel();
            AtualizarPergunta();
        }

        private void AtualizarPergunta()
        {
            lblPergunta.Text = perguntasControle.ProximaPergunta();
        }


        private void btnRuim_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Ruim = false;
            AtualizarPergunta();
            //avaliacaoModel.SalvarVoto();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Regular = false;
            AtualizarPergunta();
            //avaliacaoModel.SalvarVoto();
        }

        private void btnBom_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Bom = false;
            AtualizarPergunta();
            //avaliacaoModel.SalvarVoto();
        }

        private void btnOtimo_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Otimo = false;
            AtualizarPergunta();
            //avaliacaoModel.SalvarVoto();
        }

        private void btnExcelente_Click(object sender, EventArgs e)
        {
            avaliacaoControle.Excelente = false;
            AtualizarPergunta();
            //avaliacaoModel.SalvarVoto();
        }
    }
}