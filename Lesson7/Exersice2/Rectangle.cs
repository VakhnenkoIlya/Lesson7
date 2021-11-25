using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2
{
    class Rectangle:Point
    { 
        public double Length { get; set; }
        public double Width { get; set; }
        public double Square { get; set; }
        public override double CalculateArea(double length, double width)
        {
           Length = length;
           Width = width;
           return Square = Width*Length;
        }
    }
}
//1