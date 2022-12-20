using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public class AviaCompany
    {
        string Name = "Low-Coster";
        public void showFlights(ref flightsDatabase flights)
        {
            flights.ShowDatabase();
        }

    }
}
