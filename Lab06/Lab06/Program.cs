using System.Reflection;
using System.Diagnostics;
namespace Lab06
{
        internal partial class Program
        {

            public interface transportMove
            {
                void Move();
                void ToString();
            }
            public abstract class Transport : transportMove
            {
                public int speed { get; set; }
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
                    this.speed = rand.Next(100, 500);
                    specs.price = rand.Next(500, 1500);
                    Controller.costCount(specs.price);
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
                    public int speed { get; set; }
                    public car()
                    {
                        Random rand = new Random();
                        this.fuelConsume = rand.Next(3, 10);
                        this.speed = rand.Next(3, 10);
                    }
                public car(int fuelCons)
                {
                   
                    this.fuelConsume = fuelCons;
                    Debug.Assert(this.fuelConsume != 0, "FuelCons can't be 0");
                }
                    //public static void carsConsume(ref Transport.car[] cars)
                    // {
                    //         Random rand = new Random();
                    //     for (int i = 0; i < cars.Length; i++)
                    //     {
                    //         cars[i].fuelConsume = Convert.ToInt32(rand.Next()); 
                    //     }
                    // }

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
                    public int speed { get; set; }
                    struct Specs
                    {
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
                    public train()
                    {
                        Random rand = new Random();
                        this.speed = rand.Next(100, 500);
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
                        public vagon() : base()
                        {

                        }
                        public override void ToString()
                        {
                            Console.WriteLine($"Это машина {this}. Она может использовать Move, чтобы ехать..");
                        }
                    }

                    public class Express : train
                    {
                        int expressNumber;
                        public Express() : base()
                        {

                        }
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
                static int prices = 0;
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


                public static void findbySpeed(int speed1, int speed2, ref Container container)
                {
                    foreach (Transport c in container.cont)
                    {
                        if (c.speed > speed1 && c.speed < speed2)
                        {
                            Console.WriteLine($"Найдено транспортное средство {c} со скоростью в диапазоне от {speed1} до {speed2}");
                        }
                    }


                }

                public static void costCount(int price)
                {
                    prices += price;
                }
                public static void CW()
                {
                    Console.WriteLine("Стоимость всего транспорта агенства: " + prices);
                }
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
            try
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    cars[i] = new Transport.car(0);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("xd");
                Logger.LogErrorinConsole(e);
                Logger.LogErrorinFile(e);
                throw;
            }

            Transport.train[] trains = new Transport.train[5];

            try
            {
                for (int i = 0; i < trains.Length; i++)
                {
                    trains[i] = new Transport.train();
                }
            }
            catch (TrainSpeedExceptions e)
            {
                Logger.LogErrorinConsole(e);
                Logger.LogErrorinFile(e);
            }

            try
            {
                car1.Move();
                Console.WriteLine("----");
            }
            catch (CarMoveException e)
            {
                Logger.LogErrorinConsole(e);
                Logger.LogErrorinFile(e);
            }


            try
            {
                expressTrain.ExpressOrNot();
                Console.WriteLine("----");
            }
            catch (expressTrainExpeption e)
            {
                Logger.LogErrorinConsole(e);
                Logger.LogErrorinFile(e);
                throw;
            }

            try
            {
                expressTrain.Move();
                Console.WriteLine("----");
            }
            catch (expressTrainExpeptionMove e)
            {
                Logger.LogErrorinConsole(e);
                Logger.LogErrorinFile(e);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally all is works");
            }
                

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
                Controller.sort(ref cars);
                Controller.CW();
                Container container = new Container();

                for (int i = 0; i < cars.Length; i++)
                {
                    Controller.Adder(ref cars[i], ref container);
                }
                for (int i = 0; i < cars.Length; i++)
                {
                    Controller.Adder(ref trains[i], ref container);
                }
                Controller.findbySpeed(12, 1000, ref container);
            
            }
        }
}