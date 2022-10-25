namespace Lab09
{
    internal class Program
    {

        static void Main(string[] args)
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
            geometricFigureList.Find(7,3);
            geometricFigureList.Delete();
            foreach (GeometricFigure g in geometricFigureList)
            {
                Console.WriteLine("Длина: " + g.Length + "\n Ширина: " + g.Width + "\n---\n");
            }


            //2 задание
            /*
                +Создайте универсальную коллекцию в соответствии с вариантом задания и 
                +заполнить ее данными встроенного типа .Net (int, char,…).
                +a. Выведите коллекцию на консоль
                b. Удалите из коллекции n последовательных элементов
                c. Добавьте другие элементы (используйте все возможные методы 
                добавления для вашего типа коллекции). 
                d. Создайте вторую коллекцию (из таблицы выберите другой тип 
                коллекции) и заполните ее данными из первой коллекции.
                e. Выведите вторую коллекцию на консоль. В случае не совпадения 
                количества параметров (например, LinkedList<T> и Dictionary<Tkey, 
                TValue>), при нехватке - генерируйте ключи, в случае избыточности –
                оставляйте TValue.
                f. Найдите во второй коллекции заданное значение
            */
            var firstCollection = new Stack<int>();
            var tempCollection = new Stack<int>();
            Random random = new Random();
            int Size = 5;
            for (int i = 0; i < Size; i++)
            {
                firstCollection.Push(random.Next(i,10));
            }

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

            var secondCollection = new Queue<int>();


        }
    }
}