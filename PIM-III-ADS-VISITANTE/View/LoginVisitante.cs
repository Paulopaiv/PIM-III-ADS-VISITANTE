
using PIM_III_ADS_2P17.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using static PIM_III_ADS_2P17_AVALIACAO.Controle.AvaliacaoControle;

namespace PIM_III.View
{
    public partial class LoginVisitante : Form
    {
        private readonly PessoaModel pessoaModel;
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
                //UsuarioLogado.Codigo = pessoa.Codigo;
                Avaliacao avaliacao = new Avaliacao();
                avaliacao.ShowDialog();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }

        }
    }
}
