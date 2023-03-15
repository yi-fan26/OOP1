using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Polymophism
{
    internal class Circle:Shape
    {
        public Circle(double radius):base(0,radius)
        {
            //this.width = radius;
        }
        public override double CaleArea()
        {
            return width*width*Math.PI;
        }
    }
}
