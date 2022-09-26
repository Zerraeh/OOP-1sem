using System.Runtime.InteropServices;
using static Lab03.Program;

namespace Lab03
{
    internal class Program
    {
        /*Класс - Строка. Дополнительно перегрузить следующие 
операции: < - удаление всех символов равных заданному; + 
удаление нечетных символов; != сравнение длин строк; true - 
проверка на знаки препинания
Методы расширения:
1) Проверка наличия в строке заданных символов
2) Удаление чисел их строк*/
        public class Stroka
        {
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

            public static char[] operator <(Stroka str1, char ch)
            {
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (str1.Value[i] == ch )
                    {
                        str1.Value[i] = ' ';
                    }
                }
                return str1.Value;
            }
            public static char[] operator >(Stroka str1, char ch)
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
            
            public static char[] operator +(Stroka str1)
            {
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (i%2!=0)
                    {
                        str1.Value[i] = ' ';
                    }
                }
                return str1.Value;
            }
            public static bool operator !=(Stroka str1, Stroka str2)
            {
                if (str1.Value.Length > str2.Value.Length)
                {
                    return true;
                }else if(str1.Value.Length == str2.Value.Length)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            public static bool operator ==(Stroka str1, Stroka str2)
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

            public static bool operator true(Stroka str1)
            {
                bool result = false;
                for (int i = 0; i < str1.Value.Length; i++)
                {
                    if (str1.Value[i] == ','|| str1.Value[i] == '.' || str1.Value[i] == ';' || str1.Value[i] == ':')
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
            public static bool operator false(Stroka str1)
            {
                return false;
            }
        }

        static class StatisticOperation
        {
            public static char[] summa(Stroka str1, Stroka str2)
            {
                string str="";
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

            public static int razn(Stroka str1, Stroka str2)
            {
                return Math.Abs(str1.Value.Length - str2.Value.Length);
            }

            public static int numberofElement(Stroka str)
            {
                return str.Value.Length;
            }
        }
            
        static void Main(string[] args)
        {
            Stroka stroka1 = new Stroka();
            Stroka stroka2 = new Stroka();
            

            string str = Console.ReadLine();
            stroka1.Value = str.ToCharArray();


            str = Console.ReadLine();
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
            



        }

    }
}