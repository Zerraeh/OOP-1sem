namespace Lab10
{
    internal class Program
    {
        public static void foreacher(IEnumerable<string> outStrings)
        {
            foreach (var item in outStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            
        #region 1 задание

            #region Последовательность строк с длиной строки равной n
            int n = 4;
            Console.WriteLine($"---\tПоследовательность строк с длиной строки равной {n}\t---");
            string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            IEnumerable<string> findedStringsByLength = array.Where<string>(i => (i.Length == n));

            foreacher(findedStringsByLength);
            #endregion



            #region только летние и зимние месяцы

            Console.WriteLine("---\tЗимние месяцы\t---");
            IEnumerable<string> findedStringsByWinter = array.Where<string>(i => (i == "January" || i == "February" || i == "December"));
            foreacher(findedStringsByWinter);

            Console.WriteLine("---\tЛетние месяцы\t---");
            IEnumerable<string> findedStringsBySummer = array.Where<string>(i => (i == "June" || i == "July" || i == "August"));
            foreacher(findedStringsBySummer);

            #endregion



            #region запрос вывода месяцев в алфавитном порядке
            Console.WriteLine("---\tМесяцы в алфавитном порядке\t---");
            IEnumerable<string> outputMonthesByAlphabet = array.OrderBy(i => i);
            foreacher(outputMonthesByAlphabet);
            #endregion



            #region запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х
            Console.WriteLine("---\tСодержится буква «u» и длиной имени >=4\t---");
            IEnumerable<string> countMonthesWithU = array.Where(i =>(i.Contains("u")&&(i.Length>=4)));
            foreacher(countMonthesWithU);
            #endregion



            #endregion
        }
    }
}