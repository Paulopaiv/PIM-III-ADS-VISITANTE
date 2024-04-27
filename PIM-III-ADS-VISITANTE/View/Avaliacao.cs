using System;
using System.Windows.Forms;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Modelo;

namespace PIM_III.View
{
    public partial class Avaliacao : Form
    {
        PerguntasControle perguntas;
        AvaliacaoControle avaliacao;

        public Avaliacao()
        {
            InitializeComponent();

            perguntas = new PerguntasControle(avaliacao, gpbAvaliacao);

            this.WindowState = FormWindowState.Maximized;

            ExibirPerguntaAtual();
        }

        public AvaliacaoControle AvaliacaoControle
        {
            get => default;
            set
            {
            }
        }

        public PerguntasControle PerguntasControle
        {
            get => default;
            set
            {
            }
        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {

                AvaliacaoControle avaliacao = new AvaliacaoControle(
                    ckbRuim, ckbRegular, ckbBom, ckbOtimo, ckbExcelente
                );

                AvaliacaoModel avaliacaoModel = new AvaliacaoModel(perguntas, avaliacao);
                avaliacaoModel.RegistrarVoto();

                perguntas.LimparSelecaoCheckBox(gpbAvaliacao.Controls);

                ExibirPerguntaAtual();
            }
        }

        private void ExibirPerguntaAtual()
        {
            lblPergunta.MaximumSize = new Size(1200, 0);
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            lblPergunta.Text = perguntas.ObterPerguntaAtual();
            int topPosition = (int)(7 * CreateGraphics().DpiY / 2.54);
            int leftPosition = (this.ClientSize.Width - lblPergunta.Width) / 2;
            lblPergunta.Location = new Point(leftPosition, topPosition);
        }
    }
}
