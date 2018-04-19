using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //扮演具体适配器的角色 实现具体的适配方案
    public class PrintBanner : Banner, Print
    {
        //print 通过接口定义具体的需求，即强化 或者弱化
        //通过Banner 实现具体的需求 强化 弱化
        //通过PrintBanner 作为中间件 
        //使使用者可以调用Print接口定义的方法
        //并返回具体Banner中具体实现处理的结果
        //
        //PrintBanner 将接口（Print）与具体实现（Banner）串联起来
        public void PrintStrong()
        {
            base.ShowWithParen();
        }

        public void PrintWeak()
        {
            base.ShowWithAster();
        }

        public PrintBanner(string str)
            :base(str)
        {

        }
    }
}
