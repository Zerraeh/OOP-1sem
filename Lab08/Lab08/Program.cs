using System.ComponentModel;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Lab08
{
    internal class Program
    {

        public class User
        {
            public delegate void UpgradeHandler(string message);
            public event UpgradeHandler? UpgradeNotify;

            public delegate void workHandler(string message);
            public event workHandler? workNotify;
            string str1;
            //UpgradeHandler Upgrade = (str1) => UpgradeNotify?.Invoke("Улучшение!");
            /*public void Upgrade()
            {
                UpgradeNotify?.Invoke("Улучшение!");
            }*/

            public void Work()
            {
                workNotify?.Invoke("Работяга работает(");
            }
        }
        public static class StringCorrector
        {
            
            public static void DoOperation(string str1, string str2, Action<string, string> op) => op(str1, str2);
            public static void Concat(string str1, string str2) => Console.WriteLine("Контеканация строк: " + str1+str2);
            public static void NoSpace(string str1, string str2) => Console.WriteLine("str1 без пробелов: " + str1.Replace(' ', ',')+ "\nstr2 без пробелов: " + str2.Replace(' ', ','));
            public static void toUpper(string str1, string str2) => Console.WriteLine("str1: "+str1.ToUpper() + "\nstr2: " + str2.ToUpper());
            public static void toLower(string str1, string str2) => Console.WriteLine("str1: "+str1.ToLower() + "\nstr2: " + str2.ToUpper());
            public static void NoComas(string str1, string str2) => Console.WriteLine("str1: "+str1.Replace(',', ' ') + "\nstr2: " + str2.Replace(',', ' '));
        }
        static void Main(string[] args)
        {
            User user = new User();
            string str1 = "str1 ,";
            string str2 = "str2 ,";
            StringCorrector.DoOperation(str1, str2, StringCorrector.NoComas);
            string[] str = new string[5];
            try
            {
                str[4] = "anything";
                Console.WriteLine("It's OK");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception");
            }

        }

    }
}