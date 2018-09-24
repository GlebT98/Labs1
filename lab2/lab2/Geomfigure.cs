using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Geomfigure
    {
            public string Type
            {
                get
                {
                    return this._Type;
                }
                protected set
                {
                    this._Type = value;
                }
            }
            string _Type;
            public abstract double Area();

            public override string ToString()
            {
                return this.Type + ", площадь которого = " + this.Area().ToString();
            }
    }
}
