using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_20
{
    public class MemBook
    {
        private int id { get; set; }
        private int page=1;
        readonly int max_pages = 2;
        public void ReadNext()
        {
            if (page < max_pages)
            {
                page++;
                Console.WriteLine("Страница номер: "+page);
            }
            else
            {
                Console.WriteLine("Конец книги.");
            }
        }
        public BookMemento SavePage()
        {
            Console.WriteLine("Закладка установлена на " + page);
            return new BookMemento(id, page);
        }
        public void LoadPage(BookMemento memento)
        {
            this.id = memento.id;
            this.page = memento.page;
            Console.WriteLine("Страница восстановлена по закладке: " +page);

        }
    }

    public class PageHistory
    {
        public Stack<BookMemento> BookMementoStack { get; private set; }
        public PageHistory()
        {
            BookMementoStack = new Stack<BookMemento>();
        }
    }
    
    public class BookMemento
    {
        public int id { get; set; }
        public int page { get; set; }

        public BookMemento(int id, int page)
        {
            this.id = id;
            this.page = page;
        }
    }
}
