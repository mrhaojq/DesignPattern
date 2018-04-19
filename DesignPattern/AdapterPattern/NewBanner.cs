using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class NewBanner
    {
        private string _str;
        public NewBanner(string str)
        {
            _str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine($"({_str})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{_str}*");
        }
    }
}
