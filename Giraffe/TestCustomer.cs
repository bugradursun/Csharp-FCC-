//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
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

            Excel.Application excelUygulama = new Excel.Application();
            excelUygulama.Visible = true;
            Excel.Workbook workbook = excelUygulama.Workbooks.Add(System.Reflection.Missing.Value); //workbook olusturduk
            Excel.Worksheet sayfa1 = workbook.Sheets[1]; //worksheet olusturduk ve 1. index 0 degil 1 oluyor.!

            string[] basliklar = { "Personel no", "Ad", "Soyad", "Semt", "Sehir" };
            Excel.Range range;
            for(int i = 0; i<basliklar.Length; i++)
            {
                range = sayfa1.Cells[1, (1 + i)];
                range.Value2 = basliklar[i];
            }


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
