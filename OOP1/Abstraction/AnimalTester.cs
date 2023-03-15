using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.abstraction
{
    internal class AnimalTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======DOG======");
            Animal d=new Dog();
            d.Move();
            d.MakeSound();
            Console.WriteLine("======EAGLE=====");
            Animal eg=new Eagle();
            eg.Move();
            eg.MakeSound();
            Console.ReadLine();
        }
    }
}
