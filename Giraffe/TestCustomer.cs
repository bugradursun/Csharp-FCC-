//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace ExcelDataBase
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I376K2M;Initial Catalog=ProjelerVT;Integrated Security=True");

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sqlCumlesi = "SELECT PersonelNo,Ad,Soyad,Semt,Sehir FROM Personel";
                SqlCommand sqlCommand = new SqlCommand(sqlCumlesi, baglanti);
                SqlDataReader sdr = sqlCommand.ExecuteReader(); //okuma islemni yapar
                while(sdr.Read())
                {
                    string pno = sdr[0].ToString();
                    string ad = sdr[1].ToString();
                    string soyad = sdr[2].ToString();
                    string semt = sdr[3].ToString();
                    string sehir = sdr[4].ToString();

                    richTextBox1.Text = richTextBox1.Text + pno + "" +  ad + "" + soyad + "" + semt + "" + sehir + "\n";

                }
                
            } catch(Exception ex) {
                MessageBox.Show("SQL Query sırasında hata bulundu!, Hata Kodu:SQLREAD01 \n" + ex.ToString());
            }
            finally {
                if(baglanti != null) //baglanti zaten var yok sorgula
                    baglanti.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
