using System;
using System.Drawing;


namespace Exersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new();
            rectangle.ChangeColor(Color.White);
            Console.WriteLine(rectangle.Print());
            Console.WriteLine(rectangle.CalculateArea(2,2));
            Point point = new ();
            point.IsVisible = false;
            Console.WriteLine(point.Print());
        }
    }
}//1
