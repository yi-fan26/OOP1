using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Polymophism
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Shape sh=new Shape(4,5);
            Console.WriteLine("Shape area:" + sh.CaleArea());
            Shape sq = new Square(6);
            Console.WriteLine("Square area:" + sq.CaleArea());
            Shape ci = new Circle(5);
            Console.WriteLine("Circle area:" + Math.Round( ci.CaleArea(),2));
            Shape re = new Rectangle(3,4);
            Console.WriteLine("Rectangle area:" + re.CaleArea() );
            Console.ReadLine();
        }
    }
}
