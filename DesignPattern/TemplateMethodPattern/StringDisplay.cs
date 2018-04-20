using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemplateMethodPattern
{
    public class StringDisplay : AbstractDisplay
    {
        public override void Close()
        {
            WriteLine("+--close----+");
        }

        public override void Open()
        {
            WriteLine("+---open----+");
        }

        public override void Print()
        {
            WriteLine("Hello,World");
        }
    }
}
