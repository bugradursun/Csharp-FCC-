using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            initializeMap();
            aracListesiniOlustur();
        }

        private void aracListesiniOlustur()
        {
            list = new List<Arac>();
            list.Add(new Arac("34CHL926","Tır","Ankara","London",new PointLatLng(40.05,32.22)));
            list.Add(new Arac("06ABC01", "Kamyon", "İstanbul", "London", new PointLatLng(39.22, 27.67)));
            list.Add(new Arac("35BGR66", "Tır", "Ankara", "İstanbul", new PointLatLng(40.67, 30.24)));
            list.Add(new Arac("07ADS01", "Ticari", "Ankara", "London", new PointLatLng(41.09, 12.23)));
            list.Add(new Arac("34FB1907", "Tır", "Ankara", "Bursa", new PointLatLng(40.30, 32.47)));


        }

        private void initializeMap()
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new GMap.NET.PointLatLng(36.0,42.0); //enlem ve boylam koordinatları (lattitude ve longitude)
            map.Zoom = 4;
            map.MinZoom = 3;
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

        private void button1_Click(object sender, EventArgs e)
        {
            PointLatLng lokasyon1 = new PointLatLng(Convert.ToDouble(textBoxEnlem.Text),Convert.ToDouble(textBoxBoylam.Text));
            GMarkerGoogle marker = new GMarkerGoogle(lokasyon1,GMarkerGoogleType.red_pushpin);
            marker.ToolTipText = "Lokasyon1\n Tır\nTo İstanbul"; //markerın uzerine gelince 'Lokasyon1' gorunecek
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black; 
            marker.ToolTip.TextPadding = new Size(10, 10);
            marker.Tag = 101;

            //.2.markeri olustuyurouz

            GMarkerGoogle marker2 = new GMarkerGoogle(lokasyon1, GMarkerGoogleType.orange);
            marker2.Tag = 102;


            //daha sonra marker(lar) ı eklemeliyiz
            //ÖNCE OVERLAY(KATMAN) OLUSTURUP SONRA MARKER EKLİYORUZ !!

            katman1.Markers.Add(marker);
            katman1.Markers.Add(marker2);

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

        private void button3_Click(object sender, EventArgs e)
        {
            PointLatLng lokasyon2 = new PointLatLng(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text));
            GMarkerGoogle marker2 = new GMarkerGoogle(lokasyon2, GMarkerGoogleType.red_dot);
            marker2.Tag = 102;
            katman1.Markers.Add(marker2);
        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
