
using PIM_III_ADS_2P17;
using PIM_III_ADS_2P17.Controle;
using PIM_III_ADS_2P17_AVALIACAO.Controle;
using static PIM_III_ADS_2P17_AVALIACAO.Controle.AvaliacaoControle;

namespace PIM_III.View
{
    public partial class LoginVisitante : Form   
    {
        private readonly PessoaModel pessoaModel;
       
        public LoginVisitante()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

          
        }

       

        private void LoginVisitante_Resize(object sender, EventArgs e)
        {

        }

        //private void BtnEntrar_Click(object sender, EventArgs e)
        //{
        //    pessoa.Codigo = txbCodigoVisitante.Text; 

        //    pessoaModel.Login(pessoa);

        //    if (pessoa.Mensagem.Equals($"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir."))
        //    {
        //        MessageBox.Show(pessoa.Mensagem);
        //        UsuarioLogado.Codigo = pessoa.Codigo;
        //        Avaliacao avaliacao = new Avaliacao();
        //        avaliacao.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show(pessoa.Mensagem);
        //    }
        //}

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            // Verifica se o texto da caixa de texto não está vazio
            if (!string.IsNullOrEmpty(txbCodigoVisitante.Text))
            {
                PessoaControle pessoa = new PessoaControle();
                    pessoa.Codigo = txbCodigoVisitante.Text;

                // Chama o método Login de pessoaModel
                pessoaModel.Login(pessoa);

                // Verifica se a mensagem é a esperada e executa a lógica correspondente
                if (pessoa.Mensagem.Equals($"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir."))
                {
                    MessageBox.Show(pessoa.Mensagem);
                    UsuarioLogado.Codigo = pessoa.Codigo;
                    Avaliacao avaliacao = new Avaliacao();
                    avaliacao.ShowDialog();
                }
                else
                {
                    MessageBox.Show(pessoa.Mensagem);
                }
            }
            else
            {
                // Trata o caso em que o texto da caixa de texto está vazio
                MessageBox.Show("Por favor, insira um código válido.");
            }
        }


    }
}
