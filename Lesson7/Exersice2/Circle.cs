using System;

namespace Exersice2
{
    class Circle : Point
    {
        public double Radius { get; set; }
        private double P = 3.14;
        public int Square { get; set; }
        public override double CalculateArea(double radius, double p)
        {
            Radius = radius;
            P = p;
            return (Square = (int)(P * Math.Pow(Radius, 2)));
        }
    }
}
//1