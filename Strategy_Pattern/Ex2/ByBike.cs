using Strategy_Pattern.Ex2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class ByBike : ITransport
    {
        public double GetTransported(int distance)
        {
            double price = 10;
            double time = distance * 3;
            Console.WriteLine($"You chose to go by bike. This will cost you {price} and take you {time} minutes");
            return price;
        }
    }
}
