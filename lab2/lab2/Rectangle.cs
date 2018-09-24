using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Rectangle : Geomfigure, IPrint
    {
        double Width { get; set; }
        double Height { get; set; }
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            double Result = this.Width * this.Height;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
