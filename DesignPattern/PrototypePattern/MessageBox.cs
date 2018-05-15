using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Framework;
using static System.Console;

namespace PrototypePattern
{
    public class MessageBox : Product
    {
        private char _decochar;

        public MessageBox(char decochar)
        {
            _decochar = decochar;
        }

        public Product CreateClone()
        {
            return new MessageBox(_decochar);
        }

        public void Use(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length+4; i++)
            {
                Write(_decochar);
            }
            WriteLine();
            WriteLine($"{_decochar} {s} {_decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Write(_decochar);
            }
            WriteLine();
        }
    }
}
