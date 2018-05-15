using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace VisitorPattern
{
    public class ListVisitor : Visitor
    {
        private string _currentDir = "";

        public override void Visit(File file)
        {
            WriteLine($"{_currentDir}/{file}");
        }

        public override void Visit(Directory directory)
        {
            WriteLine($"{_currentDir}/{directory}");
            string saveDir = _currentDir;
            _currentDir = _currentDir + "/" + directory.GetName();

            foreach (var item in directory.list)
            {
                item.Accept(this);
            }

            _currentDir = saveDir;
        }
    }
}
