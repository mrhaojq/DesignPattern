using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookShelf : Aggregate
    {
        public Iterator iterator()
        {
            return new BookShelfIterator(this);
        }

        private Book[] _books;
        private int _last = 0;
 

        public BookShelf(int maxsize)
        {
            this._books = new Book[maxsize];
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books[_last] = book;
            _last++;
        }

        public int GetLength()
        {
            return _last;
        }
    }
}
