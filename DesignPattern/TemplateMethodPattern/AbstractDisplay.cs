using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class AbstractDisplay
    {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();

        /*
         * 定义处理流程
         * 不能使用接口，接口中不能实现方法体
         */ 
        public void Display()
        {
            Open();
            for (int i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }
}
