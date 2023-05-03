using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Interfaces
{
    internal class Rectangle :IShape,IDrawable
    {
        public double Length { get; set; }
        public double width { get; set; }

        public Rectangle(double x,double y)
        {
            Length= x;
            width= y;
        }
        public void ApplyColor()
        {
            Console.WriteLine("Color");
        }

        public double CalcArea()
        {
            return Length*width;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing");
        }

        public void PrintShape()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
