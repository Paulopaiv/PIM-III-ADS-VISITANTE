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
            ckbBom = new CheckBox();
            ckbRegular = new CheckBox();
            ckbOtimo = new CheckBox();
            ckbRuim = new CheckBox();
            ckbExcelente = new CheckBox();
            gpbAvaliacao = new GroupBox();
            lblPergunta = new Label();
            gpbAvaliacao.SuspendLayout();
            SuspendLayout();
            // 
            // ckbBom
            // 
            ckbBom.Anchor = AnchorStyles.None;
            ckbBom.Appearance = Appearance.Button;
            ckbBom.AutoSize = true;
            ckbBom.FlatAppearance.BorderSize = 0;
            ckbBom.FlatStyle = FlatStyle.Flat;
            ckbBom.Image = (Image)resources.GetObject("ckbBom.Image");
            ckbBom.Location = new Point(802, 68);
            ckbBom.Name = "ckbBom";
            ckbBom.Size = new Size(126, 136);
            ckbBom.TabIndex = 15;
            ckbBom.UseVisualStyleBackColor = true;
            ckbBom.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // ckbRegular
            // 
            ckbRegular.Anchor = AnchorStyles.None;
            ckbRegular.Appearance = Appearance.Button;
            ckbRegular.AutoSize = true;
            ckbRegular.FlatAppearance.BorderSize = 0;
            ckbRegular.FlatStyle = FlatStyle.Flat;
            ckbRegular.Image = (Image)resources.GetObject("ckbRegular.Image");
            ckbRegular.Location = new Point(401, 72);
            ckbRegular.Name = "ckbRegular";
            ckbRegular.Size = new Size(126, 129);
            ckbRegular.TabIndex = 14;
            ckbRegular.UseVisualStyleBackColor = true;
            ckbRegular.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // ckbOtimo
            // 
            ckbOtimo.Anchor = AnchorStyles.None;
            ckbOtimo.Appearance = Appearance.Button;
            ckbOtimo.AutoSize = true;
            ckbOtimo.FlatAppearance.BorderSize = 0;
            ckbOtimo.FlatStyle = FlatStyle.Flat;
            ckbOtimo.Image = (Image)resources.GetObject("ckbOtimo.Image");
            ckbOtimo.Location = new Point(1195, 72);
            ckbOtimo.Name = "ckbOtimo";
            ckbOtimo.Size = new Size(126, 129);
            ckbOtimo.TabIndex = 16;
            ckbOtimo.UseVisualStyleBackColor = true;
            ckbOtimo.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // ckbRuim
            // 
            ckbRuim.Anchor = AnchorStyles.None;
            ckbRuim.Appearance = Appearance.Button;
            ckbRuim.AutoSize = true;
            ckbRuim.FlatAppearance.BorderSize = 0;
            ckbRuim.FlatStyle = FlatStyle.Flat;
            ckbRuim.Image = (Image)resources.GetObject("ckbRuim.Image");
            ckbRuim.Location = new Point(0, 73);
            ckbRuim.Name = "ckbRuim";
            ckbRuim.Size = new Size(126, 126);
            ckbRuim.TabIndex = 13;
            ckbRuim.UseVisualStyleBackColor = true;
            ckbRuim.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // ckbExcelente
            // 
            ckbExcelente.Anchor = AnchorStyles.None;
            ckbExcelente.Appearance = Appearance.Button;
            ckbExcelente.AutoSize = true;
            ckbExcelente.FlatAppearance.BorderSize = 0;
            ckbExcelente.FlatStyle = FlatStyle.Flat;
            ckbExcelente.Image = (Image)resources.GetObject("ckbExcelente.Image");
            ckbExcelente.Location = new Point(1587, 74);
            ckbExcelente.Name = "ckbExcelente";
            ckbExcelente.Size = new Size(126, 124);
            ckbExcelente.TabIndex = 17;
            ckbExcelente.UseVisualStyleBackColor = true;
            ckbExcelente.CheckedChanged += CheckBoxes_CheckedChanged;
            // 
            // gpbAvaliacao
            // 
            gpbAvaliacao.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gpbAvaliacao.BackColor = Color.Transparent;
            gpbAvaliacao.Controls.Add(ckbOtimo);
            gpbAvaliacao.Controls.Add(ckbExcelente);
            gpbAvaliacao.Controls.Add(ckbRuim);
            gpbAvaliacao.Controls.Add(ckbRegular);
            gpbAvaliacao.Controls.Add(ckbBom);
            gpbAvaliacao.FlatStyle = FlatStyle.Flat;
            gpbAvaliacao.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gpbAvaliacao.Location = new Point(51, 527);
            gpbAvaliacao.Name = "gpbAvaliacao";
            gpbAvaliacao.Size = new Size(1722, 245);
            gpbAvaliacao.TabIndex = 12;
            gpbAvaliacao.TabStop = false;
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
            // Avaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1825, 875);
            Controls.Add(gpbAvaliacao);
            Controls.Add(lblPergunta);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Avaliacao";
            Text = "Pergunta01";
            gpbAvaliacao.ResumeLayout(false);
            gpbAvaliacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbnRuim;
        private RadioButton rbnRegular;
        private RadioButton rbnBom;
        private RadioButton rbnOtimo;
        private RadioButton rbnExcelente;
        private CheckBox ckbBom;
        private CheckBox ckbRegular;
        private CheckBox ckbOtimo;
        private CheckBox ckbRuim;
        private CheckBox ckbExcelente;
        private GroupBox gpbAvaliacao;
        private Label lblPergunta;
    }
}
