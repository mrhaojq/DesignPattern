using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class NewPrintBanner:NewPrint
    {
        //无法继承多个类，只能通过创建具体处理类的实例的方式
        //调用特定的适配器
        private NewBanner _banner;

        public NewPrintBanner(string str)
        {
            _banner = new NewBanner(str);
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
            //throw new NotImplementedException();
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
            //throw new NotImplementedException();
        }
    }
}
