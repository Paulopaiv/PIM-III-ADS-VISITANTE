using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace PIM_III_ADS_VISITANTE.View
{
    public partial class Obrigado : Form
    {
        private MediaAvaliacaoModel mediaAvaliacao;
        private WinFormsTimer timer;
        public Obrigado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timer = new WinFormsTimer();
            timer.Interval = 40000;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        internal void SetMediaAvaliacao(MediaAvaliacaoModel mediaAvaliacao)
        {
            this.mediaAvaliacao = mediaAvaliacao;
            pictureBox1.Image = mediaAvaliacao.ObterImagemMedia();
            lblQuantidade.Text = mediaAvaliacao.Mensagem;
            lblMedia.Text = mediaAvaliacao.MediaMensagem;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            LoginVisitante login = new LoginVisitante();
            login.Show();
            timer.Stop();
        }
    }
}
