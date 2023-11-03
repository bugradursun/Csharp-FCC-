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
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            tumKayitlariGoster(); //musteri formu acildiginda baslangicta musterilerin gozukmesi icin!
        }
    }
}
