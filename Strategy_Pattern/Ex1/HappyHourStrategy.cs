using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class HappyHourStrategy:IBillingStrategy
    {
        public double GetActPrice(double rawPrice) 
        {
            return rawPrice * 0.5;
        } 
    }
}
