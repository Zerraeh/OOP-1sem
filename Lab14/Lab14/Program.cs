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

            Console.WriteLine($"Name\t-\t{domain.FriendlyName}\nConfig Details\t-\t{domain.SetupInformation}\nAssemblies list:");

            foreach (var assembly in domain.GetAssemblies())
            {
                Console.WriteLine(assembly);
            }
            #endregion
        }
    }
}