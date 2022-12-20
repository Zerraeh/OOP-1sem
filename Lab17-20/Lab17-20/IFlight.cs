using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    internal interface IFlight
    {
        int places { get; set; }
        void FlightRaspDelete(int flightNumber);

    }
}
