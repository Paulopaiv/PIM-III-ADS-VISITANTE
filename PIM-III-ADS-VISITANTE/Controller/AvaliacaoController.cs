using System.Windows.Forms;

namespace PIM_III_ADS_VISITANTE.Model
{
    public class AvaliacaoController
    {

        private bool ruim;
        private bool regular;
        private bool bom;
        private bool otimo;
        private bool excelente;

        public AvaliacaoController()
        {

        }

        public AvaliacaoController(bool ruim, bool regular, bool bom, bool otimo, bool excelente)
        {
            this.ruim = ruim;
            this.regular = regular;
            this.bom = bom;
            this.otimo = otimo;
            this.excelente = excelente;
        }

        public string AvaliacaoSelecionada()
        {
            if (Ruim)
            {
                return "Ruim";
            }
            else if (Regular)
            {
                return "Regular";
            }
            else if (Bom)
            {
                return "Bom";
            }
            else if (Otimo)
            {
                return "Otimo";
            }
            else if (Excelente)
            {
                return "Excelente";
            }
            else
            {
                return "Nenhuma avaliação selecionada";
            }
        }

        public bool Excelente
        {
            get
            {
                return excelente;
            }
            set
            {
                excelente = value;
            }
        }

        public bool Otimo
        {
            get
            {
                return otimo;
            }
            set
            {
                otimo = value;
            }
        }

        public bool Bom
        {
            get
            {
                return bom;
            }
            set
            {
                bom = value;
            }
        }

        public bool Regular
        {
            get
            {
                return regular;
            }
            set
            {
                regular = value;
            }
        }

        public bool Ruim
        {
            get
            {
                return ruim;
            }
            set
            {
                ruim = value;
            }
        }

        public AvaliacaoModel AvaliacaoModel
        {
            get => default;
            set
            {
            }
        }
    }
}





