using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.abstraction
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("buck");
        }
        public override void Move()
        {
            Console.WriteLine("run");
        }
    }
}
