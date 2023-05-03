using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Interfaces
{
    internal class Square : IShape
    {
        public double side { get; set; }
        public Square(double x) 
        { 
        side= x;
        } 
        public double CalcArea()
        {
            return side*side;
        }

        public void PrintShape()
        {
            Console.WriteLine("Square");
        }
    }
}
