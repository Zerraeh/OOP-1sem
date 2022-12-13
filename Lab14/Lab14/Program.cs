using System.Diagnostics;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1st
            var allProcs = Process.GetProcesses();
                /*Определите и выведите на консоль / в файл все запущенные процессы:id, имя, приоритет, 
                время запуска, текущее состояние, сколько всего времени использовал процессор и т.д.*/
            foreach (var proc in allProcs)
            {
                try
                {
                    Console.WriteLine($"ID\t-\t{proc.Id}\nName\t-\t{proc.ProcessName}\nPriority\t-\t{proc.BasePriority}\nLaunchTime\t-\t{proc.StartTime}"); //:id, имя, приоритет, время запуска, текущее состояние, сколько всего времени использовал процессор
                }
                catch
                {
                    Console.WriteLine();
                }
            }
            #endregion

            #region 2nd
            /*Исследуйте текущий домен вашего приложения: имя, детали конфигурации, все сборки,
            загруженные в домен.Создайте новый домен.Загрузите туда сборку.Выгрузите домен.*/
            var domain = AppDomain.CurrentDomain;
            string longName = "system, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
            domain.Load(longName);

            Console.WriteLine($"Name\t-\t{domain.FriendlyName}\nConfig Details\t-\t{domain.SetupInformation}\nAssemblies list:");

            foreach (var assembly in domain.GetAssemblies())
            {
                Console.WriteLine(assembly);
            }
            //AppDomain.Unload(domain);

            #endregion

            #region 3rd
            /*Создайте в отдельном потоке следующую задачу расчета(можно сделать sleep для
            задержки) и записи в файл и на консоль простых чисел от 1 до n(задает пользователь). 
            Вызовите методы управления потоком(запуск, приостановка, возобновление и т.д.) Во
            время выполнения выведите информацию о статусе потока, имени, приоритете, числовой
            идентификатор и т.д*/
            void count(object pnum)
            {
                int num = (int)pnum;
                for (int i = 1; i < num; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            }
            Thread countThread = new Thread(new ParameterizedThreadStart(count));
            countThread.Name = "myThread";
            countThread.Start(9);
            Thread.Sleep(1000);
            countThread.Suspend();

            Console.WriteLine($"Имя: {countThread.Name}\nСтатус: {countThread.ThreadState}\nПриоритет: {countThread.Priority}\nЧисловой идентификатор: {countThread.ManagedThreadId}");

            countThread.Resume();

            Thread.Sleep(500);

            #endregion

            #region 4th
            /*Создайте два потока.Первый выводит четные числа, второй нечетные до n и
            записывают их в общий файл и на консоль. Скорость расчета чисел у потоков – разная.
            a.Поменяйте приоритет одного из потоков.
            b.Используя средства синхронизации организуйте работу потоков, таким образом, 
            чтобы
            i.выводились сначала четные, потом нечетные числа
            ii.последовательно выводились одно четное, другое нечетное.*/
            XD.OneTwoThread();
            Thread.Sleep(500);
            Console.WriteLine("---");
            XD.MultipleThread();
            Thread.Sleep(500);
            Console.WriteLine("\n");

            #endregion

            #region 5th
            //Придумайте и реализуйте повторяющуюся задачу на основе класса Timer
            TimerCallback timerCallback = new TimerCallback(objforCallback);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(500);
            void objforCallback(object obj)
            {
                Console.WriteLine(DateTime.Now);
            }
            #endregion
        }
    }
}