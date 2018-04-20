using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*在父类中定义处理流程的框架
             * 在子类中实现具体的处理的模式
            */

            AbstractDisplay charDisplay = new CharDisplay('H');
            charDisplay.Display();

            AbstractDisplay stringDisplay = new StringDisplay();
            stringDisplay.Display();

            ReadKey();
        }
    }
}
