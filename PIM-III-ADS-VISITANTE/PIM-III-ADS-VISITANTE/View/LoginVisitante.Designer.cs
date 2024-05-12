namespace PIM_III_ADS_VISITANTE.View
{
    partial class LoginVisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVisitante));
            txbCodigoVisitante = new TextBox();
            BtnEntrar = new Button();
            lblNome = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txbCodigoVisitante
            // 
            txbCodigoVisitante.Anchor = AnchorStyles.Right;
            txbCodigoVisitante.BorderStyle = BorderStyle.FixedSingle;
            txbCodigoVisitante.ForeColor = SystemColors.ActiveCaptionText;
            txbCodigoVisitante.Location = new Point(59, 35);
            txbCodigoVisitante.Name = "txbCodigoVisitante";
            txbCodigoVisitante.Size = new Size(306, 23);
            txbCodigoVisitante.TabIndex = 2;
            txbCodigoVisitante.Click += TextBox1_Click;
            // 
            // BtnEntrar
            // 
            BtnEntrar.Anchor = AnchorStyles.Right;
            BtnEntrar.BackColor = Color.Transparent;
            BtnEntrar.Cursor = Cursors.Hand;
            BtnEntrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEntrar.ForeColor = Color.Black;
            BtnEntrar.Location = new Point(146, 64);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(160, 42);
            BtnEntrar.TabIndex = 3;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.ControlLightLight;
            lblNome.Location = new Point(59, 7);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(148, 25);
            lblNome.TabIndex = 14;
            lblNome.Text = "Token Visitante";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BtnEntrar);
            panel1.Controls.Add(txbCodigoVisitante);
            panel1.Controls.Add(lblNome);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(1259, 463);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 129);
            panel1.TabIndex = 15;
            // 
            // LoginVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1100);
            Controls.Add(panel1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginVisitante";
            Text = "LoginVisitante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txbNomeCompleto;
        private TextBox txbCodigoVisitante;
        private Button BtnEntrar;
        private Label lblNome;
        private Panel panel1;
    }
}