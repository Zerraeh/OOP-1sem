namespace Lab09
{
    internal class Program
    {
        #region Часть первого задания
        public static void First()
        {
            GeometricFigure[] geometricFigures = new GeometricFigure[3]
            {
                new GeometricFigure(5,3),
                new GeometricFigure(6,3),
                new GeometricFigure(7,3),
            };
            Collection geometricFigureList = new Collection(geometricFigures);
            foreach (GeometricFigure g in geometricFigureList)
            {
                Console.WriteLine("Длина: " + g.Length + "\n Ширина: " + g.Width + "\n---\n");
            }
            geometricFigureList.Find(7, 3);
            geometricFigureList.Delete();
            foreach (GeometricFigure g in geometricFigureList)
            {
                Console.WriteLine("Длина: " + g.Length + "\n Ширина: " + g.Width + "\n---\n");
            }
        }
        #endregion


        #region Второе задание
        public static void Second()
        {
            //2 задание
            /*
                +Создайте универсальную коллекцию в соответствии с вариантом задания и 
                +заполнить ее данными встроенного типа .Net (int, char,…).
                +a. Выведите коллекцию на консоль
                +b. Удалите из коллекции n последовательных элементов
                +c. Добавьте другие элементы (используйте все возможные методы 
                +добавления для вашего типа коллекции). 
                +d. Создайте вторую коллекцию (из таблицы выберите другой тип 
                +коллекции) и заполните ее данными из первой коллекции.
                +e. Выведите вторую коллекцию на консоль. В случае не совпадения 
                +количества параметров (например, LinkedList<T> и Dictionary<Tkey, 
                +TValue>), при нехватке - генерируйте ключи, в случае избыточности –
                +оставляйте TValue.
                +f. Найдите во второй коллекции заданное значение
            */
            var firstCollection = new Stack<int>();
            var tempCollection = new Stack<int>();
            Random random = new Random();
            int Size = 10;

            //заполняем первую коллекцию
            for (int i = 0; i < Size; i++)
            {
                firstCollection.Push(random.Next(i, 10));
            }
            //выводим первую коллекцию
            Console.WriteLine("\n\nВывод первой коллекции: ");
            for (int i = 0; i < Size; i++)
            {
                int temp = firstCollection.Pop();
                tempCollection.Push(temp);
                Console.WriteLine($"{i}\t-\t{temp}");
            }

            //Удаление n элементов:
            int n = 4;
            for (int i = 0; i < n; i++)
            {
                tempCollection.Pop();
            }
            //Добавление n новых элеметов(в коллекции Stack есть только Push)
            for (int i = 0; i < n; i++)
            {
                tempCollection.Push(random.Next(i, 10));
            }
            Size -= n;

            //2ая коллекция
            var secondCollection = new Queue<int>();
            var secondTempCollection = new Queue<int>();

            //заполняем вторую коллекцию элементами первой
            for (int i = 0; i < Size; i++)
            {
                int temp = tempCollection.Pop();
                firstCollection.Push(temp);
                secondCollection.Enqueue(temp);
            }
            Console.WriteLine("Вывод второй коллекции: ");
            for (int i = 0; i < Size; i++)
            {
                int temp = secondCollection.Dequeue();
                secondTempCollection.Enqueue(temp);
                Console.WriteLine($"{i}\t-\t{temp}");
            }

            //нахождение элемента внутри второй коллекции
            Console.WriteLine("Найденный элемент: ");
            int findValue = 4;
            for (int i = 0; i < Size; i++)
            {
                int temp;
                temp = secondTempCollection.Dequeue();
                secondCollection.Enqueue(temp);
                if (temp == findValue)
                {
                    Console.WriteLine($"Элемент {findValue} существует во второй коллекции");
                }
            }
        }
        #endregion


        #region Третье задание
        public static void Third()
        {

        }
        #endregion
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine($"\n\t--- Выполнение {n} задания: ");
            First();
            n++;

            Console.WriteLine($"\n\t--- Выполнение {n} задания: ");
            Second();
            n++;

            Console.WriteLine($"\n\t--- Выполнение {n} задания: ");
            Third();

        } 
    }
}