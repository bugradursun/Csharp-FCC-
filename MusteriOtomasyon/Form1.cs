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
            dataGridView1.ClearSelection();
            textBoxMusteriId.Text = "0"; //uygulamayi ilk calistirdigimizdaki gozukecek olan musteri id 
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriId.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxAylikGelir.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxKrediyeUygunMu.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxSehir.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();
           
        }
    }
}