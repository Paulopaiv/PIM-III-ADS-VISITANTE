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
            lblPergunta.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPergunta.ForeColor = SystemColors.ControlLightLight;
            lblPergunta.Location = new Point(862, 356);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(196, 50);
            lblPergunta.TabIndex = 5;
            lblPergunta.Text = "Perguntas";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRuim
            // 
            btnRuim.BackColor = Color.Transparent;
            btnRuim.BackgroundImageLayout = ImageLayout.Center;
            btnRuim.FlatAppearance.BorderSize = 0;
            btnRuim.FlatStyle = FlatStyle.Flat;
            btnRuim.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRuim.ForeColor = Color.Silver;
            btnRuim.Location = new Point(107, 21);
            btnRuim.Name = "btnRuim";
            btnRuim.Size = new Size(169, 210);
            btnRuim.TabIndex = 13;
            btnRuim.Text = "Ruim";
            btnRuim.TextAlign = ContentAlignment.BottomCenter;
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
            btnRegular.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegular.ForeColor = Color.Silver;
            btnRegular.ImageIndex = 1;
            btnRegular.Location = new Point(396, 21);
            btnRegular.Name = "btnRegular";
            btnRegular.Size = new Size(179, 210);
            btnRegular.TabIndex = 14;
            btnRegular.Text = "Regular";
            btnRegular.TextAlign = ContentAlignment.BottomCenter;
            btnRegular.UseVisualStyleBackColor = false;
            btnRegular.Click += btnAvaliacao_Click;
            // 
            // btnBom
            // 
            btnBom.BackColor = Color.Transparent;
            btnBom.BackgroundImageLayout = ImageLayout.None;
            btnBom.FlatAppearance.BorderSize = 0;
            btnBom.FlatStyle = FlatStyle.Flat;
            btnBom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBom.ForeColor = Color.Silver;
            btnBom.ImageIndex = 2;
            btnBom.Location = new Point(699, 21);
            btnBom.Name = "btnBom";
            btnBom.Size = new Size(184, 210);
            btnBom.TabIndex = 15;
            btnBom.Text = "Bom";
            btnBom.TextAlign = ContentAlignment.BottomCenter;
            btnBom.UseVisualStyleBackColor = false;
            btnBom.Click += btnAvaliacao_Click;
            // 
            // btnOtimo
            // 
            btnOtimo.BackColor = Color.Transparent;
            btnOtimo.BackgroundImageLayout = ImageLayout.None;
            btnOtimo.FlatAppearance.BorderSize = 0;
            btnOtimo.FlatStyle = FlatStyle.Flat;
            btnOtimo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOtimo.ForeColor = Color.Silver;
            btnOtimo.ImageIndex = 3;
            btnOtimo.Location = new Point(988, 21);
            btnOtimo.Name = "btnOtimo";
            btnOtimo.Size = new Size(179, 210);
            btnOtimo.TabIndex = 16;
            btnOtimo.Text = "Ótimo";
            btnOtimo.TextAlign = ContentAlignment.BottomCenter;
            btnOtimo.UseVisualStyleBackColor = false;
            btnOtimo.Click += btnAvaliacao_Click;
            // 
            // btnExcelente
            // 
            btnExcelente.BackColor = Color.Transparent;
            btnExcelente.BackgroundImageLayout = ImageLayout.None;
            btnExcelente.FlatAppearance.BorderSize = 0;
            btnExcelente.FlatStyle = FlatStyle.Flat;
            btnExcelente.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcelente.ForeColor = Color.Silver;
            btnExcelente.ImageIndex = 4;
            btnExcelente.Location = new Point(1291, 3);
            btnExcelente.Name = "btnExcelente";
            btnExcelente.Size = new Size(176, 228);
            btnExcelente.TabIndex = 17;
            btnExcelente.Text = "Excelente";
            btnExcelente.TextAlign = ContentAlignment.BottomCenter;
            btnExcelente.UseVisualStyleBackColor = false;
            btnExcelente.Click += btnAvaliacao_Click;
            // 
            // pnlAvaliacao
            // 
            pnlAvaliacao.Anchor = AnchorStyles.None;
            pnlAvaliacao.BackColor = Color.Transparent;
            pnlAvaliacao.Controls.Add(btnExcelente);
            pnlAvaliacao.Controls.Add(btnOtimo);
            pnlAvaliacao.Controls.Add(btnRegular);
            pnlAvaliacao.Controls.Add(btnBom);
            pnlAvaliacao.Controls.Add(btnRuim);
            pnlAvaliacao.ForeColor = Color.Transparent;
            pnlAvaliacao.Location = new Point(173, 513);
            pnlAvaliacao.Name = "pnlAvaliacao";
            pnlAvaliacao.Size = new Size(1574, 231);
            pnlAvaliacao.TabIndex = 18;
            // 
            // Avaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1100);
            Controls.Add(pnlAvaliacao);
            Controls.Add(lblPergunta);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Avaliacao";
            RightToLeft = RightToLeft.Yes;
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
