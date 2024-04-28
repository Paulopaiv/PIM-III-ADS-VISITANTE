
using PIM_III_ADS_2P17.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Modelo;
using static PIM_III_ADS_2P17_AVALIACAO.Controle.AvaliacaoControle;

namespace PIM_III.View
{
    public partial class LoginVisitante : Form
    {
        private PessoaModel pessoaModel;
        private PessoaControle pessoa;
       


        public LoginVisitante()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaControle();
            pessoaModel = new PessoaModel();
           
        }


        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = txbCodigoVisitante.Text;

            pessoaModel.Login(pessoa);

            if (pessoaModel.Mensagem.Equals($"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir."))
            {
                MessageBox.Show(pessoaModel.Mensagem);
                Avaliacao avaliacao = new Avaliacao(pessoa);
                avaliacao.ShowDialog();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }

        }
    }
}
