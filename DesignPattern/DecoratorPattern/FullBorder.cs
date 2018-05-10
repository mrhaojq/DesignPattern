using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DecoratorPattern
{
    public class FullBorder : Border
    {
        public FullBorder(Display display)
            : base(display)
        {

        }

        public override int GetColumns()
        {
            return 1 + base._display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return 1 + base._display.GetRows() + 1;
        }

        public override string GetRowTexts(int row)
        {
            if (row == 0)
            {
                return "+" + MakeLine('-', base._display.GetColumns()) + "+";
            }
            else if (row == base._display.GetRows() + 1)
            {
                return "+" + MakeLine('-', base._display.GetColumns()) + "+";
            }
            else
            {
                return "|" + base._display.GetRowTexts(row - 1) + "|";
            }
        }

        private string MakeLine(char ch, int count)
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                strBuilder.Append(ch);
            }
            return strBuilder.ToString();
        }
    }
}
