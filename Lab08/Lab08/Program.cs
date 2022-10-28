using System.ComponentModel;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static Lab08.Program;


namespace Lab08
{
    internal class Program
    {

        public class User
        {
            public delegate void UpgradeHandler(string message, string issue);
            public event UpgradeHandler? UpgradeNotify;

            UpgradeHandler UpgradeHandle = (str1, str2) => Console.WriteLine(str1 + "\t" + str2);
            

            public delegate void workHandler();
            public event workHandler? workNotify;
            int lvlCup = 0;
            public void Upgrade()
            {
                UpgradeHandle($"{lvlCup}", "lvl");
                Console.WriteLine("Upgrades, people, upgrades!");
            }

            public void Work()
            {
                lvlCup++;
                if (lvlCup % 4 == 0)
                {
                    workNotify?.Invoke();
                }
               
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

            user.workNotify += user.Upgrade;
            for (int i = 0; i < 8; i++)
            {
                user.Work();
            }
            
            
            string str1 = "str1 ,";
            string str2 = "str2 ,";
            StringCorrector.DoOperation(str1, str2, StringCorrector.NoComas);
        }

    }
}