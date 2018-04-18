using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
   public class Book
    {
        private string _name;
        public Book(string name)
        {
            _name = name;
        }
        public String GetName()
        {
            return _name;
        }
    }
}
