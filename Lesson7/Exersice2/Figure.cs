using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2
{
    abstract class Figure:IMovable,IColorChangeble
    {
        public bool IsVisible  { get; set; }
        public Color FigureColor;
        public int X{ get; set; }
        public int Y { get; set; }
        public void MoveVertically(int deltaY)
        {
                Y += deltaY;  
        }
        public void MoveGorizon(int deltaX)
        {
            X += deltaX;
        }  
        public void ChangeColor(Color newColor)
        {
            FigureColor = newColor;
        }
        public virtual  double CalculateArea(double number1, double number2)
        {
            return 0;
        }
        public string Print()
        {
                return $"цвет фигуры {FigureColor}, видимость фигуры {IsVisible}";
        }
        public Figure(Color color, bool visible)
        {
            FigureColor = color;
            IsVisible = visible;
        }
        public Figure():this (Color.Red, true)
        {
           
        }
    }
}
//1