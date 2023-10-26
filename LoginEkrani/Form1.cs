using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LoginEkrani
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I376K2M;Initial Catalog=ProjelerVT;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }
        private string sha256KoduOlustur(string s)
        {
            var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
            var sb = new StringBuilder();
            for(int i = 0;i<bytes.Length;i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString(); 
        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {
            
            string sorgu = "SELECT KullaniciAdi FROM Kullanici WHERE KullaniciAdi = @P1 ";
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text); //P1 parameter = kullaniciadi inputu!
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if(reader.HasRows)
                {
                    MessageBox.Show(textBoxKullaniciAdi.Text + " isminde bir kullanýcý zaten mevcut!");
                }
                else
                {
                    //kayitli degilse yeni kullaniciyi ekleyecegiz
                    sqlCommand = new SqlCommand("INSERT INTO Kullanici VALUES (@P1,@P2) ",baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxKullaniciAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", sha256KoduOlustur(textBoxSifre.Text));
                    sqlCommand.ExecuteNonQuery(); 
                    
                }
            }
            catch(Exception ex) {
                MessageBox.Show("VT baglantisinda sorun olustu!, hata kodu: H001\n" + ex.Message);
            }
            finally
            {
                if(baglanti!= null)
                {
                    baglanti.Close();
                }
            }
        }
    }
}