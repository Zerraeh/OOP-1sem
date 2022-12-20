using System.Net.Http.Headers;
using System.Reflection;

namespace Lab17_20
{
    internal class Program
    {
        
        static void Main(string[] args)
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
            flights.UpdateDatabase(ref nums, ref destinations,ref places);
            AviaCompany company = new AviaCompany();
            company.showFlights(ref flights);

            // --- abs factory --- //
            Console.WriteLine("-------------------");
            FClient fClient = new FClient(new OnlineAviaFactory());
            fClient.BuyTicket();
            fClient.GoFlight();
            Console.WriteLine("-------------------");
        }
    }
}