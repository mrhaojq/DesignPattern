using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//HAHA

namespace TemplateMethodPattern
{
    public class CharDisplay : AbstractDisplay
    {
        private char _ch;
        public CharDisplay(char ch)
        {
            _ch = ch;
        }

        public override void Close()
        {
            WriteLine(">>");
        }

        public override void Open()
        {
            WriteLine("<<");
        }

        public override void Print()
        {
            Write(_ch);
        }
    }
}
