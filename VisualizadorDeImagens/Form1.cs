namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagemListBox.Items.AddRange(arquivos);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            FavoritosListBox.Items.Add(imagemListBox.Text);
        }

        private void FavoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = FavoritosListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
