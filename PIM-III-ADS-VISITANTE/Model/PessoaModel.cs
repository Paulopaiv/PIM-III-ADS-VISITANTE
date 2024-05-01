using PIM_III_ADS_2P17.Servico;
using PIM_III_ADS_VISITANTE.Controller;

namespace PIM_III_ADS_VISITANTE.Model
{
    public class PessoaModel
    {
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao());

        private string mensagem = "";

        public PessoaModel()
        {

        }

        public void Login(PessoaController pessoa)
        {
            var pessoaEncontrada = pessoaServico.BuscarPorCodigo(pessoa);

            if (pessoaEncontrada != null)
            {
                mensagem = $"Olá, {pessoaEncontrada.Nome}! Por favor, responda o questionário a seguir.";
            }
            else
            {
                mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
            }
        }

        public string Mensagem
        {
            get { return mensagem; }
        }

      
    }
}
