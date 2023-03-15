using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Encapsulation
{
    internal class Car
    {
         string name;
        int speed;
        double fuel;

        public Car(string name)
        {
            this.name = name;
            this.speed = 0;
            this.fuel = 90;
        }

        public void StartEngine()
        {
            Turnmotor();
        }
        public void Drive() 
        {
            Console.WriteLine("driving "+name);
        }
        public void SpeedUp(int x) 
        {
            speed+=x;
           Math.Round( fuel-= 5*(x*0.05),2);
        }
         private void Burnfuel() 
        {
            fuel--;
        }
        private void Turnmotor()
        {
            Burnfuel();
        }
        public void Dashboard()
        {
            Console.WriteLine($"Car : {name}\n Driving at {speed}\nCurrent Fuel: {fuel}");
        }
    }
}