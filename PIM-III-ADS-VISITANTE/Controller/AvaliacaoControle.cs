using System.Windows.Forms;

namespace PIM_III_ADS_2P17_AVALIACAO.Controle
{
    public class AvaliacaoControle
    {
        
        private CheckBox ruim;
        private CheckBox regular;
        private CheckBox bom;
        private CheckBox otimo;
        private CheckBox excelente;

        public AvaliacaoControle(CheckBox ruim, CheckBox regular, CheckBox bom, CheckBox otimo, CheckBox excelente)
        {
            this.ruim = ruim;
            this.regular = regular;
            this.bom = bom;
            this.otimo = otimo;
            this.excelente = excelente;
        }
      

        public CheckBox CheckBoxSelecionado
        {
            get
            {
                if (ruim.Checked)
                    return ruim;
                else if (regular.Checked)
                    return regular;
                else if (bom.Checked)
                    return bom;
                else if (otimo.Checked)
                    return otimo;
                else if (excelente.Checked)
                    return excelente;
                else
                    return null; // Nenhuma opção selecionada
            }
        }


        public CheckBox Ruim { get => ruim; set => ruim = value; }
        public CheckBox Regular { get => regular; set => regular = value; }
        public CheckBox Bom { get => bom; set => bom = value; }
        public CheckBox Otimo { get => otimo; set => otimo = value; }
        public CheckBox Excelente { get => excelente; set => excelente = value; }

        internal Modelo.AvaliacaoModel AvaliacaoModel
        {
            get => default;
            set
            {
            }
        }

        public void LimparSelecaoCheckBoxes()
        {
            ruim.Checked = false;
            regular.Checked = false;
            bom.Checked = false;
            otimo.Checked = false;
            excelente.Checked = false;
        }

        public static class UsuarioLogado
        {
            public static string Codigo { get; set; }
        }
    }
}
