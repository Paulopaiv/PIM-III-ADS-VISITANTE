

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    public class PerguntasControle
    {
        private int indicePergunta = 0;
        private string[] perguntas = {

             "Como você avaliaria a clareza das instruções fornecidas para interagir com as exposições?",
             "Em sua opinião, como as tecnologias utilizadas nas exposições contribuíram para a sua compreensão dos temas abordados?",
             "Como você classificaria a interatividade das exposições?",
             "Considerando sua visita ao museu, como você classificaria sua satisfação geral?",
             "Como você avalia a facilidade de uso do sistema dos totens para interagir com as exposições?"
        };

        public string[] Perguntas
        {
            get { return perguntas; }
            set { perguntas = value; }
        }

        public int IndicePergunta
        {
            get { return indicePergunta; }
            set { indicePergunta = value; }
        }
        public string PerguntaAtual()
        {
            if (indicePergunta >= 0 && indicePergunta < perguntas.Length)
            {
                return perguntas[indicePergunta];
            }
            else
            {
                return "Não há nenhuma pergunta atual.";
            }
        }

        public string ProximaPergunta()
        {
            indicePergunta++;

            if (indicePergunta >= perguntas.Length)
            {
                return "Obrigado por participar! Volte sempre.";
            }
            return perguntas[indicePergunta];
        }
    
    }
}
