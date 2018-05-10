using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DecoratorPattern
{
    public class SideBorder : Border
    {
        private char _borderChar;

        public SideBorder(Display display, char ch)
            :base(display)
        {
            _borderChar = ch;
        }

        public override int GetColumns()
        {
            return 1 + base._display.GetColumns() + 1;
        }

        public override int GetRows()
        {
            return base._display.GetRows();
        }

        public override string GetRowTexts(int row)
        {
            return _borderChar + base._display.GetRowTexts(row) + _borderChar;
        }
    }
}
