//using Microsoft.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.Collections;
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
            for (int i = 0; i < basliklar.Length; i++)
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
                int satir = 2; //ilk satır baslikti,2. satırdan itibaren verileri dolduruyoruz
                while (sdr.Read())
                {
                    string pno = sdr[0].ToString();
                    string ad = sdr[1].ToString();
                    string soyad = sdr[2].ToString();
                    string semt = sdr[3].ToString();
                    string sehir = sdr[4].ToString();

                    richTextBox1.Text = richTextBox1.Text + pno + "" + ad + "" + soyad + "" + semt + "" + sehir + "\n";

                    range = sayfa1.Cells[satir, 1];
                    range.Value2 = pno;
                    range = sayfa1.Cells[satir, 2];
                    range.Value2 = ad;
                    range = sayfa1.Cells[satir, 3];
                    range.Value2 = soyad;
                    range = sayfa1.Cells[satir, 4];
                    range.Value2 = semt;
                    range = sayfa1.Cells[satir, 5];
                    range.Value2 = sehir;

                    satir++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sırasında hata bulundu!, Hata Kodu:SQLREAD01 \n" + ex.ToString());
            }
            finally
            {
                if (baglanti != null) //baglanti zaten var yok sorgula
                    baglanti.Close();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Excel.Application exlApp;
            Excel.Workbook exlWorkbook;
            Excel.Worksheet exlWorkSheet;
            Excel.Range range;

            int rCnt = 0;
            int cCnt = 0;
            exlApp = new Excel.Application();
            exlWorkbook = exlApp.Workbooks.Open("C:\\test\\test.xlsx");
            exlWorkSheet = (Excel.Worksheet) exlWorkbook.Worksheets.get_Item(1);
            range = exlWorkSheet.UsedRange;


            //clear richtextbox2 content first
            richTextBox2.Clear();

            //since first row consists titles, rCnt will start from 2!

            for(rCnt = 2;rCnt < range.Rows.Count;rCnt++)
            {
                ArrayList list = new ArrayList();
                for(cCnt=1;cCnt<range.Columns.Count;cCnt++)
                {
                    string okunanHucre = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);
                    richTextBox2.Text = richTextBox2.Text + okunanHucre + "  ";
                    list.Add(okunanHucre);

                }
                richTextBox2.Text = richTextBox2.Text + "\n";
            }
            exlApp.Quit();
            ReleaseObject(exlWorkSheet);
            ReleaseObject(exlWorkbook);
            ReleaseObject(exlApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            } catch(Exception ex) {
                obj = null;
            }
            finally
            {
                GC.Collect(); //Daha kullanılmayacak olan nesnelerin isi bittiginde onlara ayrılan yeri boşaltır
                //to save memory and increase efficiency!
            }
            
        }
    }
}
