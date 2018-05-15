using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CompositePattern
{
    public class File : Entry
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        public override void PrintList(string prefix)
        {
            WriteLine($"{prefix}/{this}");
        }
    }
}
