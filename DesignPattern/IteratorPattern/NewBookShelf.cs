using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class NewBookShelf : Aggregate
    {
     
        public Iterator iterator()
        {
            return new NewBookShelfIterator(this);
        }

        private List<Book> _books;

        public NewBookShelf()
        {
            _books = new List<Book>();
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public int GetLength()
        {
            return _books.Count;
        }

    }
}
