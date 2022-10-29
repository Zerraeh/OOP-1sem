﻿namespace Lab10
{
    internal class Program
    {
        class Train
        {
            public string stopPoint;
            public int trainNumber;
            public DateTime startTime = new DateTime();
            int[] places = { 0, 0, 0, 0 };


            public const int MAXTRAINNUMBER = 200;


            readonly int identity;


            public static int numberofTrains = 0;

            public Train(DateTime startTime, string stopPoint = "ОШИБОЧНЫЙ ВВОД", int trainNumber = 0)
            {
                this.stopPoint = stopPoint;
                this.trainNumber = trainNumber;
                this.startTime = startTime;
                numberofTrains++;
                Random rand = new Random();
                for (int i = 0; i < this.places.Length; i++)
                {
                    this.places[i] = rand.Next(0, 100);
                }
                Console.WriteLine($"Новый поезд создан, его данные:\n Точка остановки - \t {stopPoint}\n Номер поезда - \t {trainNumber}\n Время отправки - \t {startTime}");
            }

            public void input(ref Train[] trains, int index, DateTime startTime, string stopPoint = "ОШИБОЧНЫЙ ВВОД", int trainNumber = 0)
            {
                trains[index] = new Train(startTime, stopPoint, trainNumber);
            }
            static Train()
            {
                Console.WriteLine("-\t- ПОЕЗДА -\t-");

            }


            private Train()
            {
                this.identity = trainNumber.GetHashCode();
            }


            public int platformCheck
            {
                set
                {
                    if (trainNumber >= MAXTRAINNUMBER)
                    {
                        Console.WriteLine($"Не желательно использовать номер больший чем {MAXTRAINNUMBER}, это может привести к путанице.");
                    }
                }
                get
                {
                    return 0;
                }
            }

            public void placesShow()
            {

                Console.WriteLine("-\tСПИСОК МЕСТ ПОЕЗДА\t-");
                string[] placetoString = { "Общие: ", "Купе: ", "Плацкарт: ", "Люкс: " };
                for (int i = 0; i < this.places.Length; i++)
                {
                    Console.Write(placetoString[i]);
                    Console.WriteLine(this.places[i]);
                }
                int sum = 0;
                for (int i = 0; i < this.places.Length; i++)
                {
                    sum += this.places[i];
                }

                Console.WriteLine("Всего мест в поезде: " + sum);
            }

            public static void details()
            {
                Console.WriteLine($"Информация о классе:\n Класс Trains используется для хранения информации о поездах и их особенностях");
            }
        }
        public static void foreacher(IEnumerable<string> outStrings)
        {
            foreach (var item in outStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            
        #region 1 задание

            #region Последовательность строк с длиной строки равной n
            int n = 4;
            Console.WriteLine($"---\tЗадание 1\t---\n\n");
            Console.WriteLine($"---\tПоследовательность строк с длиной строки равной {n}\t---");
            string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            IEnumerable<string> findedStringsByLength = array.Where<string>(i => (i.Length == n));

            foreacher(findedStringsByLength);
            #endregion



            #region только летние и зимние месяцы

            Console.WriteLine("---\tЗимние месяцы\t---");
            IEnumerable<string> findedStringsByWinter = array.Where<string>(i => (i == "January" || i == "February" || i == "December"));
            foreacher(findedStringsByWinter);

            Console.WriteLine("---\tЛетние месяцы\t---");
            IEnumerable<string> findedStringsBySummer = array.Where<string>(i => (i == "June" || i == "July" || i == "August"));
            foreacher(findedStringsBySummer);

            #endregion



            #region запрос вывода месяцев в алфавитном порядке
            Console.WriteLine("---\tМесяцы в алфавитном порядке\t---");
            IEnumerable<string> outputMonthesByAlphabet = array.OrderBy(i => i);
            foreacher(outputMonthesByAlphabet);
            #endregion



            #region запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х
            Console.WriteLine("---\tСодержится буква «u» и длиной имени >=4\t---");
            IEnumerable<string> countMonthesWithU = array.Where(i =>(i.Contains("u")&&(i.Length>=4)));
            foreacher(countMonthesWithU);
            #endregion



            #endregion



        #region 2 задание
            Console.WriteLine($"---\tЗадание 1\t---\n\n");
            Train[] trainArray = new Train[10];
            for (int i = 0; i < 10; i++)
            {
                trainArray[i] = new Train(DateTime.Now, "xd", i);
            }
            
            List<Train> trains = new List<Train>();
            trains.AddRange(trainArray);
            #endregion




            #region 3 задание
            
            #endregion
        }
    }
}