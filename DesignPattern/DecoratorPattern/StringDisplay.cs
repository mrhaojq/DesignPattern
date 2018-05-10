using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class StringDisplay : Display
    {
        private string _content;

        public StringDisplay(string content)
        {
            _content = content;
        }

        public override int GetColumns()
        {
            return _content.Length;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override string GetRowTexts(int row)
        {
            if (row == 0)
            {
                return _content;
            }
            else
            {
                return null;
            }
        }
    }
}
