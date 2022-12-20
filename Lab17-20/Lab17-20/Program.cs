using System.Net.Http.Headers;
using System.Reflection;

namespace Lab17_20
{
    internal class Program
    {
        public void Seventeen() 
        {
            flightsDatabase flights = new flightsDatabase();
            /*Task[] contracts = new Task[6]
            {
                new Task(()=>
                {

                }),
                new Task(()=>
                {

                }),
                new Task(()=>
                {

                }),
                new Task(()=>
                {

                }),
                new Task(()=>
                {

                }),
                new Task(()=>
                {

                }),
            };*/

            flights.UpdateDatabase(5, "в магаз))", 50);
            int[] nums = new int[5] { 1, 2, 3, 4, 6 };
            string[] destinations = new string[5] { "в Чеборсары)", "в Челябинск)0)", "в БГТУ(о нет)", "в Башн... ой", "в Казахстан" };
            int[] places = new int[5] { 50, 150, 200, 70, 30 };
            flights.UpdateDatabase(ref nums, ref destinations, ref places);
            AviaCompany company = new AviaCompany();
            company.showFlights(ref flights);

        }
        public void PatternsSeventeen()
        {
            // --- abs factory --- //
            Console.WriteLine("-------------------");
            FClient fClient = new FClient(new OnlineAviaFactory());
            fClient.BuyTicket();
            fClient.GoFlight();
            Console.WriteLine("-------------------");


            // --- builder --- //
            Console.WriteLine("-------------------");
            //BClient bClient = new BClient();
            //bClient.BuyTicket();
            Console.WriteLine("-------------------");

            // --- singleton --- //
            Console.WriteLine("-------------------");
            App app = new App();
            string[] opt1 = { "black", "Google Sans", "7pt" };
            app.SetOptions(opt1);
            string[] opt2 = { "green", "Times", "10pt" };
            app.settings = Settings.getInstance(opt2);
            Console.WriteLine(app.settings.SettingsShow());
            Console.WriteLine("-------------------");

            // --- prototype --- //
            Console.WriteLine("-------------------");
            IClient client = new Client("Alex");
            client.GetInfo();
            IClient clientClone = client.Clone();
            clientClone.GetInfo();
            Console.WriteLine("-------------------");

        }
        static void Main(string[] args)
        {
            //Seventeen();
            //PatternsSeventeen();


            // 19-20

            // --- adapter --- //
            Console.WriteLine("-------------------");
            Client client2 = new Client("Leha");
            Ticket ticket = new Ticket(5, "q", 500);
            client2.RecieveTicket(ticket);
            Console.WriteLine("-------------------");

            // --- decorator --- //
            Console.WriteLine("-------------------");
            DTicket ticket1 = new CurrentDecoratorCaseA();
            ticket1 = new CurrentDecoratorCaseB();
            ticket1.GetInfo();
            Console.WriteLine("-------------------");

            // --- state --- //
            Console.WriteLine("-------------------");
            ProcessInfo process = new ProcessInfo(new ProcessState0());
            process.BackwardGo();
            process.ForwardGo();
            process.ForwardGo();
            process.BackwardGo();
            process.ForwardGo();
            process.ForwardGo();
            Console.WriteLine("-------------------");

            // --- Iterator --- //
            Console.WriteLine("-------------------");
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);
            Console.WriteLine("-------------------");
        }


    }
}