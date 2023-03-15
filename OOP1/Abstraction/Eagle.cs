using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.abstraction
{
    internal class Eagle:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("kuk-kuk-kuk");
        }
        public override void Move() 
        { 
        Console.WriteLine("fly");
        }
    }
}
