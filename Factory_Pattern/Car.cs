using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Car:IVehicle
    {
        public Car(string naam)
        {
            Console.WriteLine($"This is a car named {naam}");
        }
    }
}
