using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Ex2
{
    class ByBus : ITransport
    {
        public double GetTransported(int distance)
        {
            double price = distance * 0.5;
            double time = distance * 1.5;
            Console.WriteLine($"You chose to go by bus. This will cost you {price} and take you {time} minutes");
            return price;
        }
    }
}
