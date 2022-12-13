using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raz();
            Dva();
            Tri();
            Chetire();
            Pyat();
            Shest();
            Sem();
            Vosem();

        }

        #region Задание 1
            //Используя TPL создайте длительную по времени задачу(на основе Task) на выбор:
            //Поиск простых чисел решетом Эратосфена
            /*Выведите идентификатор текущей задачи, проверьте во время 
            выполнения – завершена ли задача и выведите ее статус.
            2) Оцените производительность выполнения используя объект 
            Stopwatch на нескольких прогонах.*/
        static void Raz()
        {
            Stopwatch stopwatch= new Stopwatch();
            

            Task task = new Task<uint>( () => CountColvoOfSimpleNumbers(10));
            Console.WriteLine($"Task ID: {task.Id}\n Task status: {task.Status}\n---");
            stopwatch.Start();
            task.Start();

            Console.WriteLine($"Task ID: {task.Id}\n Task status: {task.Status}\n---");
            task.Wait();
            stopwatch.Stop();
            Console.WriteLine($"Task ID: {task.Id}\n Task status: {task.Status}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Метод отработал {stopwatch.ElapsedMilliseconds} мс...");
            Console.WriteLine("\n\n\n");
        }

        private static uint CountColvoOfSimpleNumbers(uint enumerationStop)
        {
            List<uint> numbers = new List<uint>();
            for (uint i = 2u; i < enumerationStop; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                for (uint j = 0; j < enumerationStop; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }
            return (uint)numbers.Count;
        }
        #endregion

        #region Задание 2
            /*Реализуйте второй вариант этой же задачи с токеном отмены
            CancellationToken и отмените задачу*/
        static void Dva()
        {
            CancellationToken cancellationToken = new CancellationToken();

            Task secondTask = Task.Factory.StartNew(CountColvoOfSimpleNumbersWithCancelation, cancellationToken);
        }
        private static uint CountColvoOfSimpleNumbersWithCancelation(object obj)
        {
            List<uint> numbers = new List<uint>();
            var token = (CancellationToken)obj;
            for (uint i = 2u; i < 50; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Canceled request");
                    token.ThrowIfCancellationRequested();
                    return 0;
                }
                for (var j = 2u; j < 1000; j++) numbers.Remove(numbers[i] * j);
            }
            return (uint)numbers.Count;
        }
        #endregion

        #region Задание 3
        /*Создайте три задачи с возвратом результата и используйте их для
        выполнения четвертой задачи.Например, расчет по формуле*/
        static void Tri()
        {
            
        }
        #endregion

        #region Задание 4
            /*Создайте задачу продолжения(continuation task) в двух вариантах:
            1) C ContinueWith -планировка на основе завершения множества
            предшествующих задач
            2) На основе объекта ожидания и методов GetAwaiter(),GetResult();*/
        static void Chetire()
        {
            

        }
        #endregion

        #region Задание 5
            /*Используя Класс Parallel распараллельте вычисления циклов For(),
            ForEach().Например, на выбор: обработку(преобразования)
            последовательности, генерация нескольких массивов по 1000000
            элементов, быстрая сортировка последовательности, обработка текстов
            (удаление, замена). Оцените производительность по сравнению с
            обычными циклами*/
        static void Pyat()
        {
            
        }
        #endregion

        #region Задание 6
            /*Используя Parallel.Invoke() распараллельте выполнение блока
            операторов.*/
        static void Shest()
        {

        }
        #endregion

        #region Задание 7
            /*Используя Класс BlockingCollection реализуйте следующую задачу:
            Есть 5 поставщиков бытовой техники, они завозят уникальные товары
            на склад(каждый по одному) и 10 покупателей – покупают все подряд, 
            если товара нет - уходят.В вашей задаче: cпрос превышает
            предложение.Изначально склад пустой.У каждого поставщика своя
            скорость завоза товара.Каждый раз при изменении состоянии склада
            выводите наименования товаров на складе.*/
        static void Sem()
        {

        }
        #endregion

        #region Задание 8
            /*Используя async и await организуйте асинхронное выполнение любого
            метода.*/
        static void Vosem()
        {

        }
        #endregion
    }
}