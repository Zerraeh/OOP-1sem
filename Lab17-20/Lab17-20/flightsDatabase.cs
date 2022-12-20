using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public class flightsDatabase
    {
        public List<string> flightDestinations;
        public List<int> flightNumbers;
        public List<int> flightPlaces;
        public List<int> date;
        public flightsDatabase()
        {
            CreateDatabase();
        }
        private void CreateDatabase()
        {
            flightDestinations = new List<string>();
            flightNumbers = new List<int>();
            flightPlaces = new List<int>();
            date = new List<int>();
        }

        public void UpdateDatabase(int num, string destination,int places)
        {
            flightNumbers.Add(num);
            flightDestinations.Add(destination);
            flightPlaces.Add(places);
            date.Add(num);
        }
        public void UpdateDatabase(ref int[] nums, ref string[] destinations, ref int[] places)
        {
            if ((nums.Length != destinations.Length) || (nums.Length != places.Length) || (destinations.Length != places.Length))
            {
                Console.WriteLine("Неверный ввод для UpdateDatabase с передачей массивов");
            }
            else
            {
                foreach (var item in nums)
                {
                    flightNumbers.Add(item);
                    date.Add(item);
                }
                foreach (var item in destinations)
                {
                    flightDestinations.Add(item);
                }
                foreach (var item in places)
                {
                    flightPlaces.Add(item);
                }
                
            }
        }

        private void DeleteDatabase()
        {
            flightNumbers.Clear();
            flightDestinations.Clear();
            flightPlaces.Clear();
        }
        ~flightsDatabase()
        {
            DeleteDatabase();
        }


        public void ShowDatabase()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t--- Табло расписания полётов: \n");
            for (int i = 0; i < flightNumbers.Count; i++)
            {
                Console.Write($"\t[{flightNumbers.ElementAt(i)}]\t-\t");
                Console.Write($"посадка {flightDestinations.ElementAt(i)}\t-\t");

                Console.Write($"дата {date.ElementAt(i)}\t-\t");
                Console.WriteLine($"места: {flightPlaces.ElementAt(i)}\n");
            }
            Console.WriteLine("-------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        

        
    }
}
