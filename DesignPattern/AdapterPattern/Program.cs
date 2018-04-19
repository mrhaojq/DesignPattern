using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern//or wrapper pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 类适配器模式 通过继承来实现适配
            Print print = new PrintBanner("Hello");
            /*
             * 通过Print 的实例调用PrintWeak和PrintStrong
             * 来进行编程的对Main类的代码而言，Banner类，ShowWithParen和ShowWithAster
             * 完全被隐藏了起来
             */
            print.PrintWeak();
            print.PrintStrong();
            #endregion

            #region 委托适配器模式 通过委托来实现适配
            //并不是C#中的委托 实际上用的时抽象类和抽象方法

            //tip 委托 这个词太过正式，通俗的将就是“交给其他人去做“
            //将某个方法中的实际处理交给其他实例的方法处理
            NewPrint newPrint = new NewPrintBanner("Hello");
            newPrint.PrintWeak();
            newPrint.PrintStrong();
            Console.ReadKey();
            #endregion
        }
    }
}
