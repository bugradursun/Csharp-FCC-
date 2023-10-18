using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeogrophicalInformatıonProject
{
    public partial class Form1 : Form
    {

        GMapOverlay katman1;
        List<Arac> list;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-I376K2M;Initial Catalog=ProjelerVT;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
            initializeMap();
            aracListesiniOlustur();
            araclariHaritadaGoster();
        }
        private void araclariHaritadaGoster()
        {
            foreach (Arac arac in list)
            {
                GMarkerGoogle markerTmp = new GMarkerGoogle(arac.Konum, GMarkerGoogleType.green_dot);
                markerTmp.Tag = arac.Plate; //tags will be unique 
                markerTmp.ToolTipText = arac.ToString(); //araclarin ustune gelince uzerlerinde yazı gozukecek
                katman1.Markers.Add(markerTmp);
                markerTmp.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                Console.WriteLine(arac.ToString());

            }
        }
        private void aracListesiniOlustur()
        {
            list = new List<Arac>();
            // veritabanindan ADO.Net ile bilgilerin cekilmesi!
            try
            {
                baglanti.Open();
                string sqlCumlesi = "SELECT Plaka, AracTipi, Nereden, Nereye, Enlem, Boylam FROM Araclar ";
                SqlDataAdapter da = new SqlDataAdapter(sqlCumlesi, baglanti);
                DataTable dt = new DataTable(); // data table grid view i dolduracak(tasarimdaki)
                da.Fill(dt); //data table i doldurduk
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }

                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    
                    list.Add(new Arac(dt.Rows[i][0].ToString(),
                                      dt.Rows[i][1].ToString(),
                                      dt.Rows[i][2].ToString(),
                                      dt.Rows[i][3].ToString(),
                                      new PointLatLng(Convert.ToDouble(dt.Rows[i][4].ToString()),
                                                      Convert.ToDouble(dt.Rows[i][5].ToString()))));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanina baglanirken sorun olustu,Hata Kodu:101\n" + 
                    ex.ToString());
            }
            finally
            {
                if(baglanti !=null)
                {
                    baglanti.Close();

                }
                
            }

        }

        private void initializeMap()
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(36.0,42.0); //enlem ve boylam koordinatları (lattitude ve longitude)
            map.Zoom = 4;
            map.MinZoom = 4;
            map.MaxZoom = 25;
            katman1 = new GMapOverlay();

            //Overlay(katman) olusturmamiz lazim
            //Harita uzerinde goruntelenecek tum componentleri bu katman eklememiz gerekmekte
            //ilk olarak yeni olusturulan katmanı harita nesnesine eklemeliyiz
            map.Overlays.Add(katman1);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            map.Dispose();
            Application.Exit(); //uygulamadan cikip takili kalmamasini sagliyoruz
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //int markerId = (int)item.Tag;
            //Console.WriteLine("id:" + markerId +"olan markera tıklandı");

            string secilenAracPlakasi = (string)item.Tag;
            foreach(Arac arac in list)
            {
                if(secilenAracPlakasi.Equals(arac.Plate))
                {
                    textBox3.Text = secilenAracPlakasi;
                    textBox4.Text = arac.Type;
                    textBox5.Text = arac.From;
                    textBox6.Text = arac.To;
                    break;
                }
            }
                 
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

     

        private void button3_Click_1(object sender, EventArgs e)
        {
            araclariHaritadaGoster();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
