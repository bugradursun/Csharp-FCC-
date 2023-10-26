using System.Data.SqlClient;

namespace LoginEkrani
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I376K2M;Initial Catalog=ProjelerVT;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKaydol_Click(object sender, EventArgs e)
        {

        }
    }
}