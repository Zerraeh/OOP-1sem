using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class XD //    иксдиииииии)
    {
        public static void OneTwoThread()
        {
            object locker = new object();

            Thread oddThread = new Thread(new ThreadStart(Odd));
            Thread evenThread = new Thread(new ThreadStart(Even));
            oddThread.Start();
            evenThread.Start();

            void Odd()
            {
                lock (locker)
                {
                    for (int i = 1; i < 10; i+=2)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine($"{i}");
                    }
                }
            }

            void Even()
            {
                lock (locker)
                {
                    for (int i = 0; i < 10; i+=2)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine($"{i}");
                    }
                }
            }
        }

        public static void MultipleThread()
        {
            Mutex mutex = new Mutex();

            Thread oddThread = new Thread(new ThreadStart(Odd));
            Thread evenThread = new Thread(new ThreadStart(Even));

            oddThread.Start();
            evenThread.Start();
            oddThread.Join();
            evenThread.Join();

            void Odd()
            {
                for (int i = 1; i < 10; i += 2)
                {
                    mutex.WaitOne();
                    Console.WriteLine($"{i}");
                    mutex.ReleaseMutex();
                }
            }

            void Even()
            {

                for (int i = 0; i < 10; i += 2)
                {
                    mutex.WaitOne();
                    Console.WriteLine($"{i}");
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
