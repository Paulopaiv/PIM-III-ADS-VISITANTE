using PIM_III_ADS_VISITANTE.Service;
using System;
using System.Collections.Generic;
using System.Drawing;

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
        private string mediaMensagem;
        private double media;

        public event EventHandler AvaliacoesConcluidas;

        public MediaAvaliacaoModel()
        {
            avaliacaoService = new AvaliacaoService();
        }

        private void OnAvaliacoesConcluidas()
        {
            AvaliacoesConcluidas?.Invoke(this, EventArgs.Empty);
        }

        public void CalcularMediaAvaliacoes()
        {
            if (avaliacaoService == null)
            {
                throw new InvalidOperationException("AvaliacaoService não foi inicializado.");
            }

            List<string> resultados = avaliacaoService.QuantidadeVotos();
            CalcularQuantidades(resultados);

            int totalAvaliacoes = Ruim + Regular + Bom + Otimo + Excelente;

            media = (Ruim *1 +Regular * 2 + Bom * 3 + Otimo * 4 + Excelente * 5)/(double)totalAvaliacoes;
            mediaMensagem = $"{media:F1}";
            mensagem = $"{totalAvaliacoes/5} avaliações";

            OnAvaliacoesConcluidas();
        }

        public Image ObterImagemMedia()
        {
            Image imagemExibir = null;
            if (this.media >= 4.5)
            {
                imagemExibir = Properties.Resources.cincoestrelas;
            }
            else if (media >= 3.5)
            {
                imagemExibir = Properties.Resources.quatroestrelas;
            }
            else if (media >= 2.5)
            {
                imagemExibir = Properties.Resources.tresestrelas;
            }
            else if (media >= 1.5)
            {
                imagemExibir = Properties.Resources.duasestrelas;
            }
            else
            {
                imagemExibir = Properties.Resources.umaestrela;
            }

            return imagemExibir;
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

        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public double Media { get => media; set => media = value; }
        public string MediaMensagem { get => mediaMensagem; set => mediaMensagem = value; }
    }
}

