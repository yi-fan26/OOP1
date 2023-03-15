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
            Rectangle rt = new Rectangle();
            rt.Draw();
            rt.PrintShape();
            rt.ApplyColor();
            Console.WriteLine("Area :"+rt.CalcArea(3,4));

            Console.ReadLine();
        }
    }
}
