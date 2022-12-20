using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    internal interface ITicket
    {
        int number { get; set; }
        string Destination { get; set; }
        int Price { get; set; }

    }
}
