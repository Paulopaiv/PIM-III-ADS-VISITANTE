using PIM_III_ADS_2P17.Controle;

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    public class PessoaControle
    {
        private string nome;
        private string codigo;

        public PessoaControle()
        {

        }

        public PessoaControle(string codigo)
        {
            this.codigo = codigo;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
    }
}
