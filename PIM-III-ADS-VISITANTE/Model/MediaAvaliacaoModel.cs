using PIM_III_ADS_2P17_AVALIACAO.Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PIM_III_ADS_VISITANTE.Model
{
    internal class MediaAvaliacaoModel
    {
        private AvaliacaoService avaliacaoService;
        private int ruim;
        private int regular;
        private int bom;
        private int otimo;
        private int excelente;
        private string mensagem;

        public MediaAvaliacaoModel()
        {
            avaliacaoService = new AvaliacaoService();
        }

        public void ExibirMediaAvaliacoes()
        {
            List<string> resultados = avaliacaoService.QuantidadeVotos();
            CalcularQuantidades(resultados);
                  
            mensagem += $"Quantidade de Votos Ruim: {Ruim}\n";
            mensagem += $"Quantidade de Votos Regular: {Regular}\n";
            mensagem += $"Quantidade de Votos Bom: {Bom}\n";
            mensagem += $"Quantidade de Votos Ótimo: {Otimo}\n";
            mensagem += $"Quantidade de Votos Excelente: {Excelente}";

          
            MessageBox.Show(mensagem);
        }

        private void CalcularQuantidades(List<string> resultados)
        {
            foreach (string resultado in resultados)
            {
                string[] partes = resultado.Split('\t');
                if (partes.Length == 2)
                {
                    string voto = partes[0].ToLower();
                    int quantidade = int.Parse(partes[1]);
                    switch (voto)
                    {
                        case "ruim":
                            Ruim = quantidade;
                            break;
                        case "regular":
                            Regular = quantidade;
                            break;
                        case "bom":
                            Bom = quantidade;
                            break;
                        case "otimo":
                            Otimo = quantidade;
                            break;
                        case "excelente":
                            Excelente = quantidade;
                            break;
                    }
                }
            }
        }

        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public int Excelente
        {
            get { return excelente; }
            set { excelente = value; }
        }

        public int Otimo
        {
            get { return otimo; }
            set { otimo = value; }
        }

        public int Bom
        {
            get { return bom; }
            set { bom = value; }
        }

        public int Regular
        {
            get { return regular; }
            set { regular = value; }
        }

        public int Ruim
        {
            get { return ruim; }
            set { ruim = value; }
        }
    }
}
