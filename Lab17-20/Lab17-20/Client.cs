using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    internal class Client : IClient
    {
        public string Name { get; set; }

        Ticket myTicket { get; set; }


        public Client(string pname)
        {
            this.Name = pname;
        }
        public IClient Clone()
        {
            return new Client(Name);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name\t-\t{this.Name}\nTicket\t-\t[{this.myTicket.number}] to [{this.myTicket.Destination}]\n\tPrice: {this.myTicket.Price}$");
        }

        public void BuyTicket(ref flightsDatabase flights)
        {
            
        }

        // adapter
        public void RecieveTicket(ITicket get)
        {
            Console.WriteLine("Билет отправлен по почте");
        }
    }
}
