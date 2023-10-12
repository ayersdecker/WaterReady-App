using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterReady.DataTypes
{
    public class Coordinate
    {
        public double longitude {  get; set; }
        public double latitude { get; set; }
        public Coordinate(double longitude, double latitude){ this.longitude = longitude; this.latitude = latitude; }
        public override string ToString(){ return $"{longitude}, {latitude}"; }
    }
}
