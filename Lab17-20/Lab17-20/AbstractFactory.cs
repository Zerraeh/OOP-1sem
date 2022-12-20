using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    //абстрактный класс билет
    abstract class FTicket
    {
        public abstract void Buy();
    }
    // абстрактный класc полёта
    abstract class Movement
    {
        public abstract void Fly();
    }

    // класс билет на 1 рейс
    class FlightTicket : FTicket
    {
        public override void Buy()
        {
            Console.WriteLine("Покупает билет на первый рейс");
        }
    }
    // класс билет на 2 рейс
    class FlightTicket2 : FTicket
    {
        public override void Buy()
        {
            Console.WriteLine("Покупает билет на второй рейс");
        }
    }
    // полет самолёта
    class FlyMovement : Movement
    {
        public override void Fly()
        {
            Console.WriteLine("Летим");
        }
    }
    
    // класс абстрактной фабрики
    abstract class AviaFactory
    {
        public abstract Movement CreateMovement();
        public abstract FTicket CreateClient();
    }
    // Фабрика создания Клиента с онлайн билетом
    class OnlineAviaFactory : AviaFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override FTicket CreateClient()
        {
            return new FlightTicket();
        }
    }
    // Фабрика создания Клиента с офлайн билетом
    class OfflineAviaFactory : AviaFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override FTicket CreateClient()
        {
            return new FlightTicket2();
        }
    }
    // клиент
    class FClient
    {
        private FTicket ticket;
        private Movement movement;
        public FClient(OnlineAviaFactory factory)
        {
            ticket = factory.CreateClient();
            movement = factory.CreateMovement();
        }
        public void GoFlight()
        {
            movement.Fly();
        }
        public void BuyTicket()
        {
            ticket.Buy();
        }
    }
}

