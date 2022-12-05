using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    [Serializable]
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
    [Serializable]
            public abstract class Transport : transportMove
            {
                public abstract void Move();
                public abstract void ToString();

                public Transport()
                {
                    Console.WriteLine("xd");
                }
        [Serializable]
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
        [Serializable]
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
            [Serializable]
            public class vagon : train
                    {
                        public override void ToString()
                        {
                            Console.WriteLine($"Это машина {this}. Она может использовать Move, чтобы ехать..");
                        }
                    }
            [Serializable]
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
        }
