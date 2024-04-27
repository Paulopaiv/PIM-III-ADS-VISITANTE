
using PIM_III_ADS_2P17.Servico;

using PIM_III_ADS_2P17_AVALIACAO.Controle;

namespace PIM_III_ADS_2P17.Controle
{
    public class PessoaModel
    {
        PessoaServico pessoaServico = new PessoaServico(new Dbconexao());

        private string mensagem = "";

        public PessoaModel()
        {

        }

        public PessoaModel(PessoaControle pessoa)
        {
            this.Login(pessoa);
        }

        //internal void Login(PessoaControle pessoa)
        //{
        //   var codigo = pessoaServico.BuscarPorCodigo(pessoa);

        //    if (codigo.Codigo != null)
        //    {
        //        this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
        //    }
        //    else
        //    {
        //        this.mensagem = $"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir.";
        //    }
        //}

        internal void Login(PessoaControle pessoa)
        {
            var codigo = pessoaServico.BuscarPorCodigo(pessoa);

            if (codigo != null)
            {
                this.mensagem = "O token fornecido é inválido. Por favor, verifique e tente novamente.";
            }
            else
            {
                this.mensagem = $"Olá, {pessoa.Nome}! Por favor, responda o questionário a seguir.";
            }
        }

        public string Mensagem
        {
            get { return mensagem; }
        }
        public PessoaServico PessoaServico
        {
            get { return pessoaServico; }
            set { pessoaServico = value; }
        }

    }
}

