using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Framework;
using static System.Console;

namespace PrototypePattern
{
    public class UnderlinePen : Product
    {
        private char _ulchar;

        public UnderlinePen(char ulchar)
        {
            _ulchar = ulchar;
        }

        public Product CreateClone()
        {
            return new UnderlinePen(_ulchar);
        }

        public void Use(string s)
        {

            int length = s.Length;
            WriteLine($"\\ {s} \\");
            for (int i = 0; i < length; i++)
            {
                Write(_ulchar);
            }
            WriteLine();
            
        }
    }
}
