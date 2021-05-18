using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Ex2
{
    class GetToAirport
    {
        ITransport _transportStrategy;
        public GetToAirport(ITransport transportStrategy)
        {
            _transportStrategy = transportStrategy;
        }
        public void Move()
        {
            _transportStrategy.GetTransported(35);
        }
    }
}
