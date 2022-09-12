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
            public void placesShow(int[] places)
            {
                int sum = 0;
                for (int i = 0; i < places.Length; i++)
                {
                    sum += places[i];
                }
                
                Console.WriteLine("Всего мест в поезде: ",sum);
            }

            public void placeToList()
            {

            }

            public void placesAndDateToList()
            {

            }
        }
        static void Main(string[] args)
        {

            int[] places = { 200, 100, 50, 10 };
            Console.WriteLine("Введите число поездов: ");
            int numberOfTrains = Convert.ToInt32(Console.ReadLine());
            Train[] trains = new Train[numberOfTrains];
            for (int i = 0; i < numberOfTrains; i++)
            {
                trains[i] = new Train();
                Console.WriteLine("Введите точку назначения: ");
                trains[i].stopPoint = Console.ReadLine();
                Console.WriteLine("Введите номер поезда: ");
                trains[i].trainNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Время отправки: ");
                trains[i].startTime = Convert.ToDateTime(Console.ReadLine());
            }

        }
    }
}