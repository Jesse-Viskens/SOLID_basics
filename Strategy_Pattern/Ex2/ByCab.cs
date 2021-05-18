using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Ex2
{
    public class ByCab : ITransport
    {
        public double GetTransported(int distance)
        {
            double price = distance * 1.5;
            double time = distance;
            Console.WriteLine($"You chose to go by cab. This will cost you {price} and take you {time} minutes");
            return price;
        }
    }
}
