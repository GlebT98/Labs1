using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Circle: Geomfigure, IPrint
    {
       // const double PI = 3.141592653589;
        double rad;
        public Circle(double b)
        {
            this.rad = b;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = this.rad * this.rad * Math.PI;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
