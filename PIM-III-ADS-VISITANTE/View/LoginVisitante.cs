
using PIM_III_ADS_VISITANTE.Controller;
using PIM_III_ADS_VISITANTE.Model;
using PIM_III_ADS_VISITANTE.View;



namespace PIM_III.View
{
    public partial class LoginVisitante : Form
    {
        private PessoaModel pessoaModel;
        private PessoaController pessoa;
        private Teclado teclado;

        public LoginVisitante()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            pessoa = new PessoaController();
            pessoaModel = new PessoaModel();
        }

       
        private void TextBox1_Click(object sender, EventArgs e)
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
            LimparCampos();
        }

        private void LimparCampos()
        {
            txbCodigoVisitante.Text = string.Empty;
        }

    }
}
