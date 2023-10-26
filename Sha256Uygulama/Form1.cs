using System.Security.Cryptography;
using System.Text;

namespace Sha256Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sha256 = SHA256.Create();
            //textBox1deki girdigimiz input => byte'a donusturuyor => byte'ý sha256 algoritmasiyla sifrelenmis diziye ceviriyoruz
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBoxMetin.Text.ToString())); // suan sifrelendi ve byte dizisine donustu

            var sb = new StringBuilder(); //bytelardan string olustrumak icin

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            textBoxKod.Text = sb.ToString();

        }
    }
}