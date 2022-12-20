using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public abstract class DTicket
    {
        public abstract void GetInfo();
    }

    public class CurrentTicket : DTicket
    {
        public override void GetInfo()
        {
            Console.WriteLine("*Информация на конкретном билете*");
        }
    }

    public abstract class Decorator : DTicket 
    {
        protected DTicket ticket;

        public void SetTicket(DTicket ticket)
        {
            this.ticket = ticket;
        }
        public override void GetInfo()
        {
            if(ticket != null) 
            {
                ticket.GetInfo();
            }
        }
    }

    public class CurrentDecoratorCaseA : Decorator
    {
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("В случае А");
        }
    }
    public class CurrentDecoratorCaseB : Decorator
    {
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("В случае B");
        }
    }

}
