using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SingletonPattern
{
   public class Singleton
    {
        //私有静态
        private static Singleton _singleton = new Singleton();

        //将构造函数设置成私有的，阻止通过外部创建该类的实例
        private Singleton()
        {
            WriteLine("生成了一个实例。");
        }

        /// <summary>
        ///提供静态的获取该私有实例的方法，只能通过这一种方式获取创建的私有实例
        /// </summary>
        /// <returns></returns>
        public static Singleton getInstance()
        {
            return _singleton;
        }
    }
}
