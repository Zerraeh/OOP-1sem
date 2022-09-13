using System.Runtime.CompilerServices;
using System.Text;

namespace Lab02
{
    internal class Program
    {
        //Создать класс Train: Пункт назначения, Номер поезда,
        //Время отправления, Число мест(общих, купе, плацкарт,
        //люкс). Свойства и конструкторы должны обеспечивать
        //проверку корректности.Добавить метод вывода общего
        //числа мест в поезде.
        //Создать массив объектов. Вывести:
        //a) список поездов, следующих до заданного пункта
        //назначения;
        //b) список поездов, следующих до заданного пункта назначения
        //и отправляющихся после заданного часа;
        class Train
        {
            public string stopPoint;
            public int trainNumber;
            public DateTime startTime = new DateTime();
            int[] places = {0, 0, 0, 0};


            public const int MAXTRAINNUMBER = 200;


            readonly int identity;
            


            public Train(string stopPoint, int trainNumber, DateTime startTime)
            {
                this.stopPoint = stopPoint;
                this.trainNumber = trainNumber;
                this.startTime = startTime;
                Console.WriteLine($"Новый поезд создан, его данные:\n Точка остановки - \t {stopPoint}\n Номер поезда - \t {trainNumber}\n Время отправки - \t {startTime}");
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
                set{
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
                Random rand = new Random();
                for (int i = 0; i < this.places.Length; i++)
                {
                    this.places[i] = rand.Next(0, 100);
                }
                Console.WriteLine("-\tСПИСОК МЕСТ ПОЕЗДА\t-");
                string[] placetoString = { "Общие: ", "Купе: ", "Плацкарт: ", "Люкс: "};
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
         }


        static void Main(string[] args)
        {
            void placeToList(string place, Train[] trains)
            {

                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].stopPoint == place)
                    {
                        Console.WriteLine($"[{i}]\tНомер " + trains[i].trainNumber + $" отправляется в {place}");
                    }
                }
            }

            void placeAndDateToList(string place, Train[] trains)
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].stopPoint == place)
                    {
                        Console.WriteLine($"[{i}]\t-\t{trains[i].trainNumber} \t-\t {trains[i].startTime}");
                    }
                }
            }
            Console.WriteLine("Введите число поездов: ");
            int numberOfTrains = Convert.ToInt32(Console.ReadLine());

            int[] NUMarray = new int[numberOfTrains+1];
            Train[] trains = new Train[numberOfTrains];
            for (int i = 0; i < numberOfTrains; i++)
            {
                string STOP;
                int NUM;
                DateTime TIME;
                Console.WriteLine("Введите точку назначения: ");
                STOP = Console.ReadLine();
                Console.WriteLine("Введите номер поезда: ");
                NUM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Время отправки: ");
                TIME = Convert.ToDateTime(Console.ReadLine());

                for (int j = 0; j <= i; j++)
                {
                    if (NUM == NUMarray[j])
                    {
                        Console.WriteLine("Номера совпали, дружище, вводи заново...");
                        i--;
                        continue;
                    }
                    else
                    {
                        NUMarray[j] = NUM;
                        trains[i] = new Train(STOP, NUM, TIME);
                    }
                }
            }
            

            int caseCheck;
            do
            {
                Console.WriteLine("Выберите один из пунктов:\n 0 - Список поездов, отправляющихся в место назначения. " +
                    "\n 1 - То же, что и в (0), но с датой отправки." +
                    " \n 2 - Вывести число оставшихся мест поезда." +
                    " \n 3 - Выход");
                caseCheck = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (caseCheck)
                {
                    case 0: Console.WriteLine("Введите место назначения: "); string placeOfStop = Console.ReadLine(); placeToList(placeOfStop, trains); break;
                    case 1: Console.WriteLine("Введите место назначения: "); placeOfStop = Console.ReadLine(); placeAndDateToList(placeOfStop, trains); break;
                    case 2: Console.WriteLine("Введите место назначения: "); placeOfStop = Console.ReadLine(); placeAndDateToList(placeOfStop, trains); Console.WriteLine("Введите номер строки: "); caseCheck = Convert.ToInt32(Console.ReadLine()); trains[caseCheck].placesShow(); break;
                    default:
                        break;
                }
            } while (caseCheck != 3);



        }
    }
}