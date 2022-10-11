using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Logger
    {
        public static void LogErrorinFile(Exception e)
        {
            using var stream = new StreamWriter(@"D:\_work\ООП\1sem\Lab06\LOG", true);
            stream.WriteLine($"Time: {DateTime.Now}");
            stream.WriteLine($"Info: {e.GetType()} - {e.Message}\n");
        }

        public static void LogErrorinConsole(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Time: {DateTime.Now}");
            Console.WriteLine($"Info: {e.GetType()} - {e.Message}");
        }
    }
}
