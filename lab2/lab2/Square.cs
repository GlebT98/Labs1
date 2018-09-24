using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Square : Rectangle, IPrint
    {
     //   private double a { get; set; }
        public Square(double width) : base(width,width)
        {
            this.Type = "Квадрат";
        }
    }
}
