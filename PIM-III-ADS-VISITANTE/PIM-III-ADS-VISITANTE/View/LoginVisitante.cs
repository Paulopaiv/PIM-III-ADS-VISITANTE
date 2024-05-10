
using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using TesteTecladoCerto;

namespace PIM_III_ADS_VISITANTE.View
{
    public partial class LoginVisitante : Form
    {
        public PessoaModel pessoaModel;
        public PessoaController pessoa;
        public Teclado teclado;

        public LoginVisitante()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaController();
            pessoaModel = new PessoaModel();
        }

        public void TextBox1_Click(object sender, EventArgs e)
        {
            // Verifica se o teclado ainda não foi instanciado
            if (teclado == null)
            {
                // Cria uma nova instância do teclado
                teclado = new Teclado();
            }

            // Define a TextBox clicada como o TextBox de destino do teclado
            teclado.SetTargetTextBox(sender as TextBox);

            teclado.Show();
        }

        public void BtnEntrar_Click(object sender, EventArgs e)
        {
            pessoa.Codigo = txbCodigoVisitante.Text;

            pessoaModel.Login(pessoa);

            if (pessoaModel.Mensagem.Equals(""))
            {
                MessageBox.Show(pessoaModel.Mensagem);
                Avaliacao avaliacao = new Avaliacao(pessoa);
                avaliacao.ShowDialog();
            }
            else
            {
                MessageBox.Show(pessoaModel.Mensagem);
            }
            LimparCampos();
        }

        public void LimparCampos()
        {
            txbCodigoVisitante.Text = string.Empty;
        }

    }
}
