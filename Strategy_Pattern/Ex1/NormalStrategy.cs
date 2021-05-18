using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class NormalStrategy: IBillingStrategy
    {
        public double GetActPrice(double rawPrice) 
        {
            return rawPrice;
        }
    }
}
