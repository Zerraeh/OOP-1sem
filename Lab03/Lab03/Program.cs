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
        }
        static void Main(string[] args)
        {
            
        }

    }
}