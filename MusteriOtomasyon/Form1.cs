using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

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
            //dataGridView1.ClearSelection();
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
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriId.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxAylikGelir.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxSehir.Text = dataGridView1.Rows[secilenSatir].Cells[5].Value.ToString();


            //textBoxKrediyeUygunMu.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            string metin = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            if (metin.Equals("True"))
                textBoxKrediyeUygunMu.Text = "Evet";
            else
                textBoxKrediyeUygunMu.Text = "Hayir";

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Musteri (Ad, Soyad, AylikGelir, " +
                    "KrediyeUygunMu, Sehir) VALUES(@P1, @P2, @P3, @P4, @P5)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxAylikGelir.Text);
                if (Convert.ToInt32(textBoxAylikGelir.Text) >= 10000)
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 1); //adding 1 value to P4 which is KrediyeUygunMu
                }
                else
                {
                    sqlCommand.Parameters.AddWithValue("@P4", 0);
                }
                sqlCommand.Parameters.AddWithValue("@P5", textBoxSehir.Text);
                sqlCommand.ExecuteNonQuery(); //SELECT YOKSA YANÝ QUERY YOKTUR VE UPDATE-INSERT-DELETE DURUMLARINDA EXECUTENONQUERY KULLAN  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayýt eklenirken hata olustu, Hata Kodu : H002\n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
                verileriGoruntule();
                metinKutulariniTemizle();
            }

        }
        private void metinKutulariniTemizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxAylikGelir.Clear();
            textBoxKrediyeUygunMu.Clear();
            textBoxSehir.Clear();
            textBoxMusteriId.Text = "0";
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutulariniTemizle();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriId.Text.Equals("0"))
            {
                MessageBox.Show("Lutfen bir musteri seciniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Musteri WHERE MusteriId = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxMusteriId.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayýt silinirken hata olustu, Hata Kodu:H003\n" + ex.Message);
                }
                finally
                {
                    if (baglanti != null)
                    {
                        baglanti.Close();
                    }
                }
                verileriGoruntule(); //secili veriler silindikten sonra guncel veriler goruntulensin
                metinKutulariniTemizle(); //silindikten sonra datagridde veriler takili kalmamsi icin!
            }
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            if (textBoxMusteriId.Text.Equals("0"))
            {
                MessageBox.Show("Lutfen musteri seciniz");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Musteri  SET Ad=@P1," +
                                     " Soyad = @P2, AylikGelir = @P3 , KrediyeUygunMu = @P4, Sehir= @P5  " +
                                     "WHERE MusteriId = @P6", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxAd.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSoyad.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxAylikGelir.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", textBoxSehir.Text);
                    if (Convert.ToInt32(textBoxAylikGelir.Text) >= 10000)
                    {
                        sqlCommand.Parameters.AddWithValue("@P4", "1");
                    }
                    else
                    {
                        sqlCommand.Parameters.AddWithValue("@P4", "0");
                    }
                    sqlCommand.Parameters.AddWithValue("@P6", textBoxMusteriId.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayýt güncellenirken hata olustu, Hata Kodu:H004\n" + ex.Message);
                }
                finally
                {
                    if (baglanti != null)
                    {
                        baglanti.Close();
                    }
                }
                verileriGoruntule();
                metinKutulariniTemizle();
            }
        }

        private void buttonAra_Click(object sender, EventArgs e) //ad,soyad veya sehire gore arama butonu click eventi
        {
            try
            {

                string sorgu = "SELECT * FROM Musteri WHERE Ad LIKE '" + textBoxAd.Text + "%'"
                    + "AND Soyad LIKE '" + textBoxSoyad.Text + "%'"
                    + "AND Sehir LIKE '" + textBoxSehir.Text + "%'";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayit aramasý yapýlýrken hata olustu, Hata Kodu: H005\n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e) //aylik gelire gore arama butonu click eventi
        {
            try
            {

                string sorgu = "SELECT * FROM Musteri WHERE AylikGelir = " + textBoxAylikGelir.Text;

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayit aramasý yapýlýrken hata olustu, Hata Kodu: H006\n" + ex.Message);
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) //tumunu goruntule methodu !
        {
            verileriGoruntule();
        }
    }
}