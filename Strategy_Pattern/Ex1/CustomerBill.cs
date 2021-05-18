using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class CustomerBill
    {
        private IList<double> drinks;

        // Get/Set Strategy
        public IBillingStrategy Strategy { get; set; }

        public CustomerBill(IBillingStrategy strategy)
        {
            drinks = new List<double>();
            Strategy = strategy;
        }

        public void Add(double price, int quantity)
        {
            drinks.Add(Strategy.GetActPrice(price * quantity));
        }

        // Payment of bill
        public void Print()
        {
            double sum = 0;
            foreach (var drinkCost in drinks)
            {
                sum += drinkCost;
            }
            Console.WriteLine($"Total due: {sum}.");
            drinks.Clear();
        }
    }
}
