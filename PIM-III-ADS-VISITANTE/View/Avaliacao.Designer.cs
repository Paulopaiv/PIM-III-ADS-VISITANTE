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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avaliacao));
            lblPergunta = new Label();
            btnRuim = new Button();
            imageList1 = new ImageList(components);
            btnRegular = new Button();
            btnBom = new Button();
            btnOtimo = new Button();
            btnExcelente = new Button();
            pnlAvaliacao = new Panel();
            pnlAvaliacao.SuspendLayout();
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
            btnRuim.FlatAppearance.BorderSize = 0;
            btnRuim.FlatStyle = FlatStyle.Flat;
            btnRuim.ImageIndex = 0;
            btnRuim.ImageList = imageList1;
            btnRuim.Location = new Point(54, 36);
            btnRuim.Name = "btnRuim";
            btnRuim.Size = new Size(105, 110);
            btnRuim.TabIndex = 13;
            btnRuim.Text = "Ruim";
            btnRuim.UseVisualStyleBackColor = false;
            btnRuim.Click += btnAvaliacao_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "moon_01-removebg-preview.png");
            imageList1.Images.SetKeyName(1, "moon_02-removebg-preview.png");
            imageList1.Images.SetKeyName(2, "moon_03-removebg-preview.png");
            imageList1.Images.SetKeyName(3, "moon_04-removebg-preview.png");
            imageList1.Images.SetKeyName(4, "moon_05-removebg-preview.png");
            imageList1.Images.SetKeyName(5, "001.png");
            imageList1.Images.SetKeyName(6, "002.png");
            imageList1.Images.SetKeyName(7, "003.png");
            imageList1.Images.SetKeyName(8, "004.png");
            imageList1.Images.SetKeyName(9, "005.png");
            // 
            // btnRegular
            // 
            btnRegular.BackColor = Color.Transparent;
            btnRegular.BackgroundImageLayout = ImageLayout.None;
            btnRegular.FlatAppearance.BorderSize = 0;
            btnRegular.FlatStyle = FlatStyle.Flat;
            btnRegular.ImageIndex = 1;
            btnRegular.ImageList = imageList1;
            btnRegular.Location = new Point(454, 36);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(105, 110);
            btnRegular.TabIndex = 14;
            btnRegular.Text = "Regular";
            btnRegular.UseVisualStyleBackColor = false;
            btnRegular.Click += btnAvaliacao_Click;
            // 
            // btnBom
            // 
            btnBom.BackColor = Color.Transparent;
            btnBom.BackgroundImageLayout = ImageLayout.None;
            btnBom.FlatAppearance.BorderSize = 0;
            btnBom.FlatStyle = FlatStyle.Flat;
            btnBom.ImageIndex = 2;
            btnBom.ImageList = imageList1;
            btnBom.Location = new Point(854, 36);
            btnBom.Name = "btnBom";
            btnBom.Size = new Size(105, 110);
            btnBom.TabIndex = 15;
            btnBom.Text = "Bom";
            btnBom.UseVisualStyleBackColor = false;
            btnBom.Click += btnAvaliacao_Click;
            // 
            // btnOtimo
            // 
            btnOtimo.BackColor = Color.Transparent;
            btnOtimo.BackgroundImageLayout = ImageLayout.None;
            btnOtimo.FlatAppearance.BorderSize = 0;
            btnOtimo.FlatStyle = FlatStyle.Flat;
            btnOtimo.ImageIndex = 3;
            btnOtimo.ImageList = imageList1;
            btnOtimo.Location = new Point(1254, 36);
            btnOtimo.Name = "btnOtimo";
            btnOtimo.Size = new Size(105, 110);
            btnOtimo.TabIndex = 16;
            btnOtimo.Text = "Otimo";
            btnOtimo.UseVisualStyleBackColor = false;
            btnOtimo.Click += btnAvaliacao_Click;
            // 
            // btnExcelente
            // 
            btnExcelente.BackColor = Color.Transparent;
            btnExcelente.BackgroundImageLayout = ImageLayout.None;
            btnExcelente.FlatAppearance.BorderSize = 0;
            btnExcelente.FlatStyle = FlatStyle.Flat;
            btnExcelente.ImageIndex = 4;
            btnExcelente.ImageList = imageList1;
            btnExcelente.Location = new Point(1654, 36);
            btnExcelente.Name = "btnExcelente";
            btnExcelente.Size = new Size(105, 110);
            btnExcelente.TabIndex = 17;
            btnExcelente.Text = "Excelente";
            btnExcelente.UseVisualStyleBackColor = false;
            btnExcelente.Click += btnAvaliacao_Click;
            // 
            // pnlAvaliacao
            // 
            pnlAvaliacao.Anchor = AnchorStyles.None;
            pnlAvaliacao.BackColor = Color.Transparent;
            pnlAvaliacao.Controls.Add(btnExcelente);
            pnlAvaliacao.Controls.Add(btnOtimo);
            pnlAvaliacao.Controls.Add(btnBom);
            pnlAvaliacao.Controls.Add(btnRegular);
            pnlAvaliacao.Controls.Add(btnRuim);
            pnlAvaliacao.ForeColor = Color.Transparent;
            pnlAvaliacao.Location = new Point(6, 555);
            pnlAvaliacao.Name = "pnlAvaliacao";
            pnlAvaliacao.Size = new Size(1815, 212);
            pnlAvaliacao.TabIndex = 18;
            // 
            // Avaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1825, 875);
            Controls.Add(pnlAvaliacao);
            Controls.Add(lblPergunta);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Avaliacao";
            Text = "Pergunta01";
            pnlAvaliacao.ResumeLayout(false);
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
        private Panel pnlAvaliacao;
        private ImageList imageList1;
    }
}
