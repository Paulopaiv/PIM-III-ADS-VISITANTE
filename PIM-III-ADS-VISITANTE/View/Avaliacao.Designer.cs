namespace PIM_III.View
{
    partial class Avaliacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avaliacao));
            lblPergunta = new Label();
            btnRuim = new Button();
            btnRegular = new Button();
            btnBom = new Button();
            btnOtimo = new Button();
            btnExcelente = new Button();
            SuspendLayout();
            // 
            // lblPergunta
            // 
            lblPergunta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPergunta.AutoSize = true;
            lblPergunta.BackColor = Color.Transparent;
            lblPergunta.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPergunta.ForeColor = SystemColors.ControlLightLight;
            lblPergunta.Location = new Point(822, 184);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(181, 46);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "Perguntas";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRuim
            // 
            btnRuim.BackColor = Color.Transparent;
            btnRuim.BackgroundImageLayout = ImageLayout.None;
            btnRuim.FlatStyle = FlatStyle.Flat;
            btnRuim.Image = (Image)resources.GetObject("btnRuim.Image");
            btnRuim.Location = new Point(60, 591);
            btnRuim.Name = "btnRuim";
            btnRuim.Size = new Size(105, 110);
            btnRuim.TabIndex = 13;
            btnRuim.Text = "Ruim";
            btnRuim.UseVisualStyleBackColor = false;
            btnRuim.Click += btnRuim_Click;
            // 
            // btnRegular
            // 
            btnRegular.BackColor = Color.Transparent;
            btnRegular.BackgroundImageLayout = ImageLayout.None;
            btnRegular.FlatStyle = FlatStyle.Flat;
            btnRegular.Image = (Image)resources.GetObject("btnRegular.Image");
            btnRegular.Location = new Point(460, 591);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(105, 110);
            btnRegular.TabIndex = 14;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = false;
            btnRegular.Click += btnRegular_Click;
            // 
            // btnBom
            // 
            btnBom.BackColor = Color.Transparent;
            btnBom.BackgroundImageLayout = ImageLayout.None;
            btnBom.FlatStyle = FlatStyle.Flat;
            btnBom.Image = (Image)resources.GetObject("btnBom.Image");
            btnBom.Location = new Point(860, 591);
            btnBom.Name = "btnBom";
            btnBom.Size = new Size(105, 110);
            btnBom.TabIndex = 15;
            btnBom.Text = "Bom";
            btnBom.UseVisualStyleBackColor = false;
            btnBom.Click += btnBom_Click;
            // 
            // btnOtimo
            // 
            btnOtimo.BackColor = Color.Transparent;
            btnOtimo.BackgroundImageLayout = ImageLayout.None;
            btnOtimo.FlatStyle = FlatStyle.Flat;
            btnOtimo.Image = (Image)resources.GetObject("btnOtimo.Image");
            btnOtimo.Location = new Point(1260, 591);
            btnOtimo.Name = "btnOtimo";
            btnOtimo.Size = new Size(105, 110);
            btnOtimo.TabIndex = 16;
            btnOtimo.Text = "Otimo";
            btnOtimo.UseVisualStyleBackColor = false;
            btnOtimo.Click += btnOtimo_Click;
            // 
            // btnExcelente
            // 
            btnExcelente.BackColor = Color.Transparent;
            btnExcelente.BackgroundImageLayout = ImageLayout.None;
            btnExcelente.FlatStyle = FlatStyle.Flat;
            btnExcelente.Image = (Image)resources.GetObject("btnExcelente.Image");
            btnExcelente.Location = new Point(1660, 591);
            btnExcelente.Name = "btnExcelente";
            btnExcelente.Size = new Size(105, 110);
            btnExcelente.TabIndex = 17;
            btnExcelente.Text = "Excelente";
            btnExcelente.UseVisualStyleBackColor = false;
            btnExcelente.Click += btnExcelente_Click;
            // 
            // Avaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1825, 875);
            Controls.Add(btnExcelente);
            Controls.Add(btnOtimo);
            Controls.Add(btnBom);
            Controls.Add(btnRegular);
            Controls.Add(btnRuim);
            Controls.Add(lblPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Avaliacao";
            Text = "Pergunta01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbnRuim;
        private RadioButton rbnRegular;
        private RadioButton rbnBom;
        private RadioButton rbnOtimo;
        private RadioButton rbnExcelente;
        private Label lblPergunta;
        private Button btnRuim;
        private Button btnRegular;
        private Button btnBom;
        private Button btnOtimo;
        private Button btnExcelente;
    }
}
