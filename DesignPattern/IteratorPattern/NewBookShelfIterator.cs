using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class NewBookShelfIterator : Iterator
    {
        private NewBookShelf _bookShelf;
        private int _index;

        public NewBookShelfIterator(NewBookShelf bookShelf)
        {
            _bookShelf = bookShelf;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index < _bookShelf.GetLength();
        }

        public object Next()
        {
            Book book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
