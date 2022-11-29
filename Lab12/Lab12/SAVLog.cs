using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lab12
{
    public static class SAVLog
    {
        public static void WriteLog(string message)
        {
            using (var stream = new StreamWriter(@"D:\_work\ООП\1sem\Lab12\Lab12\SAVlogfile.txt",true))
            {
                stream.WriteLine($"{DateTime.Now.ToString()}\t-\t{message}");
            }
        }
            /*Создать класс XXXLog.Он должен отвечать за работу с текстовым файлом
xxxlogfile.txt.в который записываются все действия пользователя и
соответственно методами записи в текстовый файл, чтения, поиска нужной
информации*/
    }
}
