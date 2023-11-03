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
    }
}
