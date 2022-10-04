namespace Lab04
{
    internal class Program
    {
        
        public interface transportMove
        {
            void Move();
        }
        public abstract class Transport : transportMove
        {
            public abstract void Move();
                
            public class car : Transport
            {
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
                public override void Move()
                {
                    Console.WriteLine("Поезд движется по рельсам.");
                }
                public class vagon : train
                {

                }

                public class Express : train
                {
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
            car1.Move();
            Transport.train.Express expressTrain = new Transport.train.Express();
            Console.WriteLine("----");
            expressTrain.ExpressOrNot();
            expressTrain.Move();
            Console.WriteLine("----");
            Transport.car.engine engine = new Transport.car.engine();
            engine.Work();
            Transport.train.vagon vagon = new Transport.train.vagon();
            vagon.Move();
        }
    }
}