namespace Lab04
{
    internal class Program
    {
        public class Printer
        {
            public void IAmPrinting(transportMove item)
            {
                item.ToString();
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
            public Transport()
            {
                Console.WriteLine("xd");
            }
            public class car : Transport
            {
                public car() : base()
                {

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
                    public void Work()
                    {
                        Console.WriteLine("Двигатель работает");
                    }
                }

            }

            public class train : Transport
            {
                int trainNumber;
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
        static void Main(string[] args)
        {
            //11 вариант - Автомобиль, Поезд, Транспортное средство, Экспресс, Двигатель, Вагон
            Transport.car car1 = new Transport.car();
            Transport.train.Express expressTrain = new Transport.train.Express();
            Transport.car.engine engine = new Transport.car.engine();
            Transport.train.vagon vagon = new Transport.train.vagon();



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

        }
    }
}