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
    public partial class UrunForm : Form
    {
        ProjelerVTEntities entities = new ProjelerVTEntities(); //initialize entities object !!
        public UrunForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumKayitlariGoster();
        }
        private void tumKayitlariGoster()
        {
            var urunler = entities.Urun.ToList();
            dataGridView1.DataSource = urunler;
            dataGridView1.ClearSelection();
            MetinKutulariniTemizle();
        }
        private void MetinKutulariniTemizle()
        {
            textBoxAdi.Clear();
            textBoxFiyati.Clear();
            textBoxUrunId.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.Adi = textBoxAdi.Text;
            urun.Fiyati = Convert.ToInt32(textBoxFiyati.Text) ; 
            try
            {
                entities.Urun.Add(urun);
                entities.SaveChanges();
                MessageBox.Show("Urun kaydı eklendi");
                tumKayitlariGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanı işlemleri sirasinda hata olustu!,HataKodu:H010\n" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex; 
            textBoxUrunId.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxAdi.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxFiyati.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster();
            textBoxUrunId.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int urunId = Convert.ToInt32(textBoxUrunId.Text); //textfieldda bulunan urunId'si ile ilgili satırı bulup nesneye donusturuyoruz
                var urun = entities.Urun.Find(urunId);
                entities.Urun.Remove(urun);
                entities.SaveChanges();
                MessageBox.Show("Urun Kaydi Silindi");
                tumKayitlariGoster();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veri Tabanı işlemleri sirasinda hata olustu!,HataKodu:H011\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int urunId = Convert.ToInt32(textBoxUrunId.Text);
                var urun = entities.Urun.Find(urunId);
                urun.Adi = textBoxAdi.Text;
                urun.Fiyati = Convert.ToInt32(textBoxFiyati.Text);
                entities.SaveChanges();
                MessageBox.Show("Bilgiler Guncellendi!");
                tumKayitlariGoster();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veri Tabanı işlemleri sirasinda hata olustu!,HataKodu:H012\n" + ex.Message);
            }
        }
    }
}
