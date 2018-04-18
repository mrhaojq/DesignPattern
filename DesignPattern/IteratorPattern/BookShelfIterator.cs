using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class BookShelfIterator : Iterator
    {
        private BookShelf _bookShelf;
        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index < _bookShelf.GetLength();
            //if (_index<_bookShelf.GetLength())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public object Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
