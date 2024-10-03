namespace VisualizadorDeImagens
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imagemListBox = new ListBox();
            FavoritosListBox = new ListBox();
            AdicionarButton = new Button();
            pictureBox1 = new PictureBox();
            removerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imagemListBox
            // 
            imagemListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imagemListBox.FormattingEnabled = true;
            imagemListBox.Location = new Point(12, 12);
            imagemListBox.Name = "imagemListBox";
            imagemListBox.Size = new Size(619, 124);
            imagemListBox.TabIndex = 0;
            imagemListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FavoritosListBox
            // 
            FavoritosListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FavoritosListBox.FormattingEnabled = true;
            FavoritosListBox.Location = new Point(12, 194);
            FavoritosListBox.Name = "FavoritosListBox";
            FavoritosListBox.Size = new Size(619, 124);
            FavoritosListBox.TabIndex = 1;
            FavoritosListBox.SelectedIndexChanged += FavoritosListBox_SelectedIndexChanged;
            // 
            // AdicionarButton
            // 
            AdicionarButton.Location = new Point(12, 150);
            AdicionarButton.Name = "AdicionarButton";
            AdicionarButton.Size = new Size(235, 29);
            AdicionarButton.TabIndex = 2;
            AdicionarButton.Text = "Adicionar aos Favoritos";
            AdicionarButton.UseVisualStyleBackColor = true;
            AdicionarButton.Click += AdicionarButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 337);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(619, 284);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // removerButton
            // 
            removerButton.Location = new Point(274, 150);
            removerButton.Name = "removerButton";
            removerButton.Size = new Size(235, 29);
            removerButton.TabIndex = 4;
            removerButton.Text = "Remover dos Favoritos";
            removerButton.UseVisualStyleBackColor = true;
            removerButton.Click += removerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 633);
            Controls.Add(removerButton);
            Controls.Add(pictureBox1);
            Controls.Add(AdicionarButton);
            Controls.Add(FavoritosListBox);
            Controls.Add(imagemListBox);
            Name = "Form1";
            Text = "Visualizador de Imagens";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox imagemListBox;
        private ListBox FavoritosListBox;
        private Button AdicionarButton;
        private PictureBox pictureBox1;
        private Button removerButton;
    }
}
