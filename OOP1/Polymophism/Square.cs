using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Polymophism
{
    internal class Square :Shape
    {
        double side;
        public Square(double side):base(side,0)
        {
            //this.length = side;
        }
        public override double CaleArea() {
            return length*length;
        }
    }
}
