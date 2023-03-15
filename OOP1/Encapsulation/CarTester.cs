using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Encapsulation
{
    internal class CarTester
    {
        static void Main(string[] args)
        {
            Car c=new Car("BMW");
            c.StartEngine();
            c.Drive();
            c.SpeedUp(30);
            c.Dashboard();
            Console.ReadLine();
        }
    }
}
