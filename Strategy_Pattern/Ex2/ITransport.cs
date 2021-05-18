using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Ex2
{
    public interface ITransport
    {
        double GetTransported(int distance);
    }
}
