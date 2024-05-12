namespace PIM_III_ADS_VISITANTE.View
{
    partial class Obrigado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obrigado));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            lblQuantidade = new Label();
            lblMedia = new Label();
            lblNotageral = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cincoestrelas.png");
            imageList1.Images.SetKeyName(1, "duasestrelas.png");
            imageList1.Images.SetKeyName(2, "quatroestrelas.png");
            imageList1.Images.SetKeyName(3, "tresestrelas.png");
            imageList1.Images.SetKeyName(4, "umaestrela.png");
            imageList1.Images.SetKeyName(5, "zeroestrelas.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.cincoestrelas;
            pictureBox1.Location = new Point(491, 632);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(939, 101);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.Transparent;
            lblQuantidade.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.ForeColor = Color.White;
            lblQuantidade.Location = new Point(1193, 763);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(237, 47);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "20 avaliações";
            lblQuantidade.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMedia
            // 
            lblMedia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMedia.AutoSize = true;
            lblMedia.BackColor = Color.Transparent;
            lblMedia.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedia.ForeColor = Color.FromArgb(0, 98, 255);
            lblMedia.Location = new Point(1240, 501);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(190, 128);
            lblMedia.TabIndex = 2;
            lblMedia.Text = "5,0";
            // 
            // lblNotageral
            // 
            lblNotageral.AutoSize = true;
            lblNotageral.BackColor = Color.Transparent;
            lblNotageral.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotageral.ForeColor = Color.White;
            lblNotageral.Location = new Point(1017, 564);
            lblNotageral.Name = "lblNotageral";
            lblNotageral.Size = new Size(217, 50);
            lblNotageral.TabIndex = 3;
            lblNotageral.Text = "Nota geral:";
            // 
            // Obrigado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1100);
            Controls.Add(lblNotageral);
            Controls.Add(lblMedia);
            Controls.Add(lblQuantidade);
            Controls.Add(pictureBox1);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Obrigado";
            Text = "Obrigado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lblQuantidade;
        private Label lblMedia;
        private Label lblNotageral;
    }
}