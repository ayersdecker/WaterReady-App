using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterReady.DataTypes;

namespace WaterReady.Models
{
    public class MainPageLocationModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Coordinate Coordinate { get; set; }
        public string ImageSource { get; set; }
        public MainPageLocationModel(string name, string description, Coordinate coordinate, string imagesource)
        {
            Name = name;
            Description = description;
            Coordinate = coordinate;
            ImageSource = imagesource;
        }
    }
}
