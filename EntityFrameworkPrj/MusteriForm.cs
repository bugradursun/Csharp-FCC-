using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkPrj
{
    public partial class MusteriForm : Form
    {
        ProjelerVTEntities entities = new ProjelerVTEntities(); //this object is the required class for CRUD operations
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonListele_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }

        private void tumKayitlariGoster()
        {
            var musterileri = entities.Customer.ToList();
            dataGridView1.DataSource = musterileri;
            dataGridView1.ClearSelection();
            MetinKutulariniTemizle();
        }
        private void MetinKutulariniTemizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxSehir.Clear();
            textBoxMusteriId.Text = "0"; 
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster(); //musteri formu acildiginda baslangicta musterilerin gozukmesi icin!
            textBoxMusteriId.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Ad = textBoxAd.Text;
            customer.Soyad = textBoxSoyad.Text;
            customer.Sehir = textBoxSehir.Text;

            try
            {
                entities.Customer.Add(customer);
                entities.SaveChanges();
                MessageBox.Show("Musteri Kaydi Eklendi");
                tumKayitlariGoster();
            }
            catch(Exception ex) {
                MessageBox.Show("Veri Tabanı işlemleri sirasinda hata olustu!,HataKodu:H001\n" + ex.Message);
            }
            finally
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxMusteriId.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxSehir.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int musteriId = Convert.ToInt32(textBoxMusteriId.Text); //musteri id'si ile silinecek olan secili veriyi bulduk
                var musteri = entities.Customer.Find(musteriId);
                entities.Customer.Remove(musteri);
                entities.SaveChanges(); 
                MessageBox.Show("Musteri Kaydi Silindi!");
                tumKayitlariGoster();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Veri Tabanı işlemleri sirasinda hata olustu!,HataKodu:H002\n" + ex.Message);
            }
        }
    }
}
