using OrnekDll;

namespace DllKullanimProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKareHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text.ToString());
            int sayininKaresi = Hesaplayici.kareHesapla(sayi);
            textBox2.Text = sayininKaresi.ToString();



        }

        private void buttonKupHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text.ToString());
            int sayininKupu = Hesaplayici.kupHesapla(sayi);
            textBox2.Text = sayininKupu.ToString();
        }
    }
}