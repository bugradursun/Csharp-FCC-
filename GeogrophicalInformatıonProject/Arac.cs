using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeogrophicalInformatıonProject
{
    internal class Arac
    {
        private string plate;
        private string type;
        private string from;
        private string to;
        private PointLatLng konum;

        public Arac(string plate,string type,string from,string to, PointLatLng konum)
        {
            this.plate = plate;
            this.type = type;
            this.from = from;
            this.to = to;
            this.Konum = konum;
        }
        public string Plate { get => plate; set => plate = value; }
        public string Type { get => type; set => type = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public PointLatLng Konum { get => konum; set => konum = value; }

        public override string ToString()
        {
            string str = Plate + "" + Type + "" + From + "" + To;
            return str;

        }

    }
}
