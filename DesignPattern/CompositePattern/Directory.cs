using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CompositePattern
{
    public class Directory : Entry
    {
        private String _name;
        private List<Entry> _entryList = new List<Entry>();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        /// <summary>
        ///递归获取条目大小
        /// </summary>
        /// <returns></returns>
        public override int GetSize()
        {
            int size = 0;
            foreach (var entry in _entryList)
            {
                Entry e = (Entry)entry;
                size += e.GetSize();
            }
            return size;
        }

        public override void PrintList(string prefix)
        {
            WriteLine($"{prefix}/{this}");
            foreach (var entry in _entryList)
            {
                Entry e = (Entry)entry;
                e.PrintList($"{prefix}/{_name}");
            }
        }

        public new Entry Add(Entry entry)
        {
            _entryList.Add(entry);
            return this;
        }
    }
}
