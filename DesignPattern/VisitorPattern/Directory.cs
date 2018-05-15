using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    public class Directory : Entry
    {
        private string _name;
        public List<Entry> list = new List<Entry>();

        public Directory(string name)
        {
            _name = name;
        }
      

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (var item in list)
            {
                size += item.GetSize();
            }
            return size;
        }

        public new Entry Add(Entry entry)
        {
            list.Add(entry);
            return this;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
