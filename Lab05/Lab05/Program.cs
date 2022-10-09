using System.ComponentModel;
using static Lab05.Program.Transport.car;

namespace Lab05
{
    internal partial class Program
    {
        static class Agency
        {
            static int prices = 0;
            public static void costCount(int price)
            {
                prices += price;
            }
            public static void CW()
            {
                Console.WriteLine("Стоимость всего транспорта агенства: "+prices);
            }
            public static void findbySpeed()
            {

            }

        }

        public interface transportMove
        {
            void Move();
            void ToString();
        }
        public abstract class Transport : transportMove
        {
            public abstract void Move();
            public abstract void ToString();

            public struct Specs
            {
                public int price;
                public int fuelConsume;
            }

            public Transport()
            {
                Random rand = new Random();
                Specs specs = new Specs();
                specs.price = rand.Next(500,1500);
                Agency.costCount(specs.price);
            }
            
            

            public class car : Transport
            {

                public int fuelConsume;
                public struct Specs
                {
                    public int speed;
                    public int price;
                }
                
                enum Type
                {
                    oil = 0,
                    electro = 1
                }

                public car()
                {
                    Random rand = new Random();
                    this.fuelConsume = rand.Next(3,10);
                }
               //public static void carsConsume(ref Transport.car[] cars)
               // {
               //         Random rand = new Random();
               //     for (int i = 0; i < cars.Length; i++)
               //     {
               //         cars[i].fuelConsume = Convert.ToInt32(rand.Next()); 
               //     }
               // }
                public static void sort(ref Transport.car[] cars)
                {
                    Console.WriteLine("Автомобили по расходу топлива: \n\n");
                    for (int i = 0; i < cars.Length; i++)
                    {
                        for (int j = 0; j < cars.Length; j++)
                        {
                            if (cars[i].fuelConsume > cars[j].fuelConsume)
                            {
                                int temp = cars[i].fuelConsume;
                                cars[i].fuelConsume = cars[j].fuelConsume;
                                cars[j].fuelConsume = temp;
                            }
                        }
                    }
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine($"[{i}]\t-\t{cars[i].fuelConsume}");
                    }
                }
                public override void ToString()
                {
                    Console.WriteLine($"Это машина {this}. Она может использовать Move, чтобы ехать..");
                }
                public override void Move()
                {
                    Console.WriteLine("Автомобиль движется по дороге.");
                }
                public sealed class engine
                {
                    enum Specs
                    {
                        disabled = 0,
                        enabled = 1
                    }
                    struct Stats
                    {
                        int status;
                        int waste;
                        int hp;
                    }
                   
                    public void Work()
                    {
                        Console.WriteLine("Двигатель работает");
                    }
                }

            }

            public class train : Transport
            {
                
                struct Specs
                {
                    int speed;
                    int price;
                    int fuelConsume;
                    int trainNumber;
                }
                enum Type
                {
                    longDistance = 0,
                    shortDistance = 1,
                    highSpeed = 2,
                    interCity = 3
                }
                public override void ToString()
                {
                    Console.WriteLine($"Это поезд {this}. Он может использовать Move, чтобы ехать по рельсам..");
                }
                public override void Move()
                {
                    Console.WriteLine("Поезд движется по рельсам.");
                }
                public class vagon : train
                {
                    public override void ToString()
                    {
                        Console.WriteLine($"Это машина {this}. Она может использовать Move, чтобы ехать..");
                    }
                }

                public class Express : train
                {
                    int expressNumber;

                    public void ExpressOrNot()
                    {
                        Console.WriteLine("Поезд является Экспрессом");
                    }
                }
            }

        }
        public class Container
        {
            public List<Object> cont = new List<Object>();
        }
        public static class Controller
        {
            public static void Adder(ref Transport a, ref Container container)
            {
                container.cont.Add(a);
            }
            public static void Adder(ref Transport.car a, ref Container container)
            {
                container.cont.Add(a);
            }
            public static void Adder(ref Transport.train a, ref Container container)
            {
                container.cont.Add(a);
            }
        }


        static void Main(string[] args)
        {
            //11 вариант - Автомобиль, Поезд, Транспортное средство, Экспресс, Двигатель, Вагон
            //11 вариант - Транспортное агенство(Эх...)

            Transport.car car1 = new Transport.car();
            Transport.train.Express expressTrain = new Transport.train.Express();
            Transport.car.engine engine = new Transport.car.engine();
            Transport.train.vagon vagon = new Transport.train.vagon();
            Transport.car[] cars = new Transport.car[5];
            for (int i = 0; i < 5; i++)
            {
                cars[i] = new Transport.car();
            }


            car1.Move();
            Console.WriteLine("----");

            expressTrain.ExpressOrNot();
            expressTrain.Move();
            Console.WriteLine("----");

            engine.Work();
            Console.WriteLine("----");

            vagon.Move();
            Console.WriteLine("----");


            //5
            Transport.train train1 = new Transport.train();

            Console.WriteLine($"Поезд экспресс? - {train1 is Transport.train.Express}");
            Transport.train.Express? expressTrain1 = train1 as Transport.train.Express;
            if (expressTrain1 == null)
            {
                Console.WriteLine("Неудачно!");
            }
            car1.ToString();
            expressTrain.ToString();

            //7
            var printer = new Printer();
            Transport[] transports = new Transport[3];
            transports[0] = train1;
            transports[1] = car1;
            transports[2] = expressTrain;

            foreach (Transport item in transports)
            {
                printer.IAmPrinting(item);
            }
            //carsConsume(ref cars);
            sort(ref cars);
            Agency.CW();
            Container container = new Container();

            for (int i = 0; i < cars.Length; i++)
            {
                Controller.Adder(ref cars[i], ref container);
            }

        }
    }
}