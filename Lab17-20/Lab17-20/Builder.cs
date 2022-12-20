using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public abstract class TicketBuilder
    {
        public BTicket Ticket { get;  set; }

        public void BuildTicket()
        {
            Ticket = new BTicket();
        }
        public abstract void SetPrice();
        public abstract void SetPlace();
        public abstract void SetDest();

    }

    class AviaCompBuild
    {
        public BTicket Create(TicketBuilder ticketBuilder)
        {
            ticketBuilder.BuildTicket();
            ticketBuilder.SetPrice();
            ticketBuilder.SetPrice();
            ticketBuilder.SetDest();
            return ticketBuilder.Ticket;
        }
    }

    public class FirstFlightB : TicketBuilder
    {
        public override void SetDest()
        {
            this.Ticket.Dest = new Dest { destination = "Камбоджа" };
        }
        public override void SetPlace()
        {
            this.Ticket.Place = new Place { place = 15 };
        }
        public override void SetPrice()
        {
            this.Ticket.Price = new Price { price = 300 };
        }
    }

    public class SecondFlightB : TicketBuilder
    {
        public override void SetDest()
        {
            this.Ticket.Dest = new Dest { destination = "Казань" };
        }
        public override void SetPlace()
        {
            this.Ticket.Place = new Place { place = 12 };
        }
        public override void SetPrice()
        {
            this.Ticket.Price = new Price { price = 100 };
        }
    }
    public class BClient
    {
        BTicket personalTicket { get; set; }
        public void BuyTicket()
        {
            AviaCompBuild avia = new AviaCompBuild();
            TicketBuilder builder = new FirstFlightB();
            personalTicket = avia.Create(builder);
            Console.WriteLine("Ура, купил новый билет, а вот и он:\n"+personalTicket.ToString());
        }
    }
    public class Price
    {
        public int price { get; set;}
    }

    public class Place
    {
        public int place { get; set;}
    }

    public class Dest
    {
        public string destination { get; set;}
    }
    public class BTicket
    {
        public Dest Dest { get; set;}
        public Place Place { get; set;}
        public Price Price { get; set;}

        public override string ToString()
        {
            StringBuilder ticInfo = new StringBuilder();
            ticInfo.Append($"Билет:\n");
            ticInfo.Append("Место назначения - " + Dest.destination);
            ticInfo.Append("\nМесто в самолёте - " + Place.place);
            ticInfo.Append("Место назначения - " + Dest.destination);
            return ticInfo.ToString();
        }
    }
        
}
