using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //适配器接口 实际需求
    public interface Print
    {
        void PrintWeak();//弱化
        void PrintStrong();//强化
    }
}
