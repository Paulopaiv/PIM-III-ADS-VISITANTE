using PIM_III_ADS_2P17.Controle;

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    public class PessoaControle
    {
        private int idadeDb;
        private string nome;
        private string idade;
        private string email;
        private string cep;
        private string codigo;
        public DateTime data;
     
        public PessoaControle()
        {

        }

        public PessoaControle(string nome, string idade, string email, string cep, string codigo, int idadeDb = 0)
        {
            this.nome = nome;
            this.idade = idade;
            this.email = email;
            this.cep = cep;
            this.codigo = codigo;
            this.idadeDb = idadeDb;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int IdadeDb
        {
            get { return idadeDb; }
            set { idadeDb = value; }
        }
        public string Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Codigo
        {
            get{ return codigo;}
            set{ codigo = value;}
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Mensagem
        {
            get;
            private set;
        }
    }
}
