namespace WinFormsCargImg
{
    public partial class Form1 : Form
    {
        OpenFileDialog abrir = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void botonImg_Click(object sender, EventArgs e)
        {
            abrir.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|JPEG|*.jpeg";
            abrir.Multiselect = true;

            if(abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(abrir.FileNames[0].ToString());
                pictureBox2.Image = System.Drawing.Image.FromFile(abrir.FileNames[1].ToString());
                pictureBox3.Image = System.Drawing.Image.FromFile(abrir.FileNames[2].ToString());
                pictureBox4.Image = System.Drawing.Image.FromFile(abrir.FileNames[3].ToString());
            }
        }
    }
}
