using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    internal class Ticket : ITicket
    {
        public int number { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }

        public Ticket(int number, string destination, int price)
        {
            this.number = number;
            Destination = destination;
            Price = price;
        }
    }
}
