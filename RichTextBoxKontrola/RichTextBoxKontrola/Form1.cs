namespace RichTextBoxKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:Tempproba.rtf");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();  
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:Tempproba.rtf");
            MessageBox.Show("Tekst spremljen");
        }
    }
}