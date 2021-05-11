using System;
using System.Collections.Generic;

namespace Factory_Pattern
{
    class Program
    {
        //SRP What?
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Unicycle");
            dictionary.Add(2, "Car");
            dictionary.Add(3, "Motorbike");
            dictionary.Add(4, "Truck");
            dictionary.Add(5, "Bicycle");

            Console.WriteLine("Enter 1 = unicycle, 2 = car, 3 = motorbike, 4 = truck");
            int chosenValue = 0;

            do
            {
                string UserInput = Console.ReadLine();
                chosenValue = Convert.ToInt32(UserInput);
            } while (chosenValue >4 || chosenValue < 1);

            Console.WriteLine("Hoe wil je je voertuig noemen?");
            string naam = Console.ReadLine();

            //IVehicle vehicle = VehicleFactory.Build(chosenValue);

            dictionary.TryGetValue(chosenValue, out string value);
            IVehicle vehicle = VehicleFactory.Build(value, naam);

            Console.WriteLine($"You've build a {vehicle.GetType().Name}");

            Console.Read();
        }
    }
}
