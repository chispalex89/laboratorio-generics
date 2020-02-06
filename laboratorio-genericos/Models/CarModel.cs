using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboratorio_genericos.Models
{
    public class CarModel
    {
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int CubicCms { get; set; }
    }
}