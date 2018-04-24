using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("start");
            Singleton obj1 = Singleton.getInstance();
            //Singleton obj2 = new Singleton(); 构造函数设置成私有的，不能通过new 创建该类的实例
            Singleton obj2 = Singleton.getInstance();

            if (obj1.Equals(obj2))
            {
                WriteLine("obj1与obj2是相同的实例。");
            }
            else
            {
                WriteLine("obj1与obj2不是相同的实例。");
            }
            WriteLine("end");
            ReadKey();
        }
    }
}
