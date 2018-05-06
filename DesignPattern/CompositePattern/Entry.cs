using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{

    public abstract class Entry
    {
        public abstract string GetName();
        public abstract int GetSize();
        public Entry Add(Entry entry)
        {
            throw new Exception("Add Entry");
        }

        public void PrintList()
        {
            PrintList("");
        }

        public abstract void PrintList(string prefix);

        //父类定义流程 子类具体实现 模板方法
        public override string ToString()
        {
            return $"{GetName()} ({GetSize()})";
        }
    }
}
