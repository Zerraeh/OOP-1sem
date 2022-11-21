using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using static Lab07.Program;

namespace Lab07
{

    internal class Program
    {
        public static void FILE_SAVE(Program.Stroka<string> e)
        {
            using var stream = new StreamWriter(@"D:\_work\ООП\1sem\Lab07\Save.txt", true);
            stream.Write("Info: ");
            stream.WriteLine(e.GetType());
            stream.WriteLineAsync(e.Value);
        }
        /*Класс - Строка. Дополнительно перегрузить следующие 
операции: < - удаление всех символов равных заданному; + 
удаление нечетных символов; != сравнение длин строк; true - 
проверка на знаки препинания
Методы расширения:
1) Проверка наличия в строке заданных символов
2) Удаление чисел их строк*/
        public interface Ioperations <T>
        {
            void Add();
            void Delete();
            void Show();
        }

        public class Stroka<T> : Ioperations<T> //where T: Transport
        {
            public void Add()
            {
                Console.WriteLine("No more adds :)");
            }
            public void Delete()
            {
                Console.WriteLine("No more Deletes :D");
            }
            public void Show()
            {
                Console.WriteLine("No more Strings :/");
            }

            public class StrokaCollection<T>
            {
                   public List<Stroka<T>> _strings = new List<Stroka<T>>();
                
                public void Add(Stroka<T> str)
                {
                    _strings.Add(str);
                }

            }
            
            public class Production
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public class Developer
                {
                    public int ID { get; set; }
                    public string FIO { get; set; }
                    public string District { get; set; }
                }
            }
            public char[] Value { get; set; }

            public static char[] operator <(Stroka<T> str1, char ch)
            {
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (str1.Value[i] == ch)
                    {
                        str1.Value[i] = ' ';
                    }
                }
                return str1.Value;
            }
            public static char[] operator >(Stroka<T> str1, char ch)
            {
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (str1.Value[i] == ch)
                    {
                        str1.Value[i] = ' ';
                    }
                }
                return str1.Value;
            }

            public static char[] operator +(Stroka<T> str1)
            {
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        str1.Value[i] = ' ';
                    }
                }
                return str1.Value;
            }
            public static bool operator !=(Stroka<T> str1, Stroka<T> str2)
            {
                if (str1.Value.Length > str2.Value.Length)
                {
                    return true;
                }
                else if (str1.Value.Length == str2.Value.Length)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            public static bool operator ==(Stroka<T> str1, Stroka<T> str2)
            {
                if (str1.Value.Length > str2.Value.Length)
                {
                    return true;
                }
                else if (str1.Value.Length == str2.Value.Length)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator true(Stroka<T> str1)
            {
                bool result = false;
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (str1.Value[i] == ',' || str1.Value[i] == '.' || str1.Value[i] == ';' || str1.Value[i] == ':')
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                return result;
            }
            public static bool operator false(Stroka<T> str1)
            {
                return false;
            }
        }

        static class StatisticOperation
        {
            public static char[] summa(Stroka<string> str1, Stroka<string> str2)
            {
                string str = "";
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    str += str1.Value[i];
                }
                for (int i = 0; i < str2.Value.Length; i++)
                {
                    str += str2.Value[i];
                }
                char[] chars = str.ToCharArray();
                return chars;
            }

            public static int razn(Stroka<string> str1, Stroka<string> str2)
            {
                return Math.Abs(str1.Value.Length - str2.Value.Length);
            }

            public static int numberofElement(Stroka<string> str)
            {
                return str.Value.Length;
            }
        }


        static void Main(string[] args)
        {

            Stroka<string>.StrokaCollection<string> Collection = new Stroka<string>.StrokaCollection<string>();
            try
            {
                Stroka<string> stroka1 = new Stroka<string>();
                Stroka<string> stroka2 = new Stroka<string>();
            


            string str = Console.ReadLine();
                string strxd = str;
            stroka1.Value = str.ToCharArray();


            str = Console.ReadLine();
                string strqw = str;
            stroka2.Value = str.ToCharArray();

            Console.Clear();
            Console.WriteLine("Ваш ввод: ");
            Console.WriteLine(stroka1.Value);
            Console.WriteLine(stroka2.Value);
            char[] charArray = StatisticOperation.summa(stroka1, stroka2);
            Console.Write("Сумма строк stroka1 и stroka2 : ");
            Console.WriteLine(charArray);
            int raznValue = StatisticOperation.razn(stroka1, stroka2);
            Console.WriteLine($"Разница длин строк : {raznValue}");
            Console.WriteLine($"Число элементов в строке stroka1 : {StatisticOperation.numberofElement(stroka1)}");

            strxd = strxd.summa(strqw);
            Console.WriteLine(strxd);
            FILE_SAVE(stroka1);
            FILE_SAVE(stroka2);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                Console.WriteLine("Done!!!");
                
            }
            
        }

    }
}