using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DecoratorPattern
{
    public abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowTexts(int row);

        public void Show()
        {
            for (int i = 0; i < this.GetRows(); i++)
            {
                WriteLine(GetRowTexts(i));
            }
        }
    }
}
