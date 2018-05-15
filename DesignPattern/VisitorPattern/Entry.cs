using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public abstract class Entry : Element
    {
        public abstract String GetName();
        public abstract int GetSize();

        public Entry Add(Entry entry)
        {
            throw new Exception();
        }

        //父类定义流程 子类具体实现 模板方法
        public override string ToString()
        {
            return $"{GetName()} ({GetSize()})";
        }
    }
}
