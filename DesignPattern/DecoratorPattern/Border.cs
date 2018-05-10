using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Border : Display
    {
        protected Display _display;

        protected Border(Display display)//子类才可调用
        {
            _display = display;
        }
    }
}
