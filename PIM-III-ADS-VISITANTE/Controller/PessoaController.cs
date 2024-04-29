namespace PIM_III_ADS_VISITANTE.Controller
{
    public class PessoaController
    {
        private string nome;
        private string codigo;

        public PessoaController()
        {

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
