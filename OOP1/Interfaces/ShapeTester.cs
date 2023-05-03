using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Interfaces
{
    internal class ShapeTester
    {
        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle(3,4);
            rt.Draw();
            rt.PrintShape();
            rt.ApplyColor();
            Console.WriteLine("Area :"+rt.CalcArea());
            Square sq=new Square(5);
            
            sq.PrintShape();
            
            Console.WriteLine("Area :" + sq.CalcArea());

            Console.ReadLine();
        }
    }
}
