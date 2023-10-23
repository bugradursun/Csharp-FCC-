using System.Data;
using System.Data.SqlClient;

namespace MusteriOtomasyon
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
            verileriGoruntule();
        }
        private void verileriGoruntule()
        {
            try
            {
                string sorgu = "SELECT MusteriId, Ad, Soyad, AylikGelir, KrediyeUygunMu, Sehir FROM Musteri ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sorgu, baglanti); // sql serverdaki verileri cekip fill metoduyla data table a alir
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanindan verileri cekerken hata olustu!, HataKodu:H001\n" + ex.Message);

            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }


    }
}