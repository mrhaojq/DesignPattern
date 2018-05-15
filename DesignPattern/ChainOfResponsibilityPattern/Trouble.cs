using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
  public  class Trouble
    {
        private int _number;
        public Trouble(int number)
        {
            _number = number;
        }

        public int GetNumber() => _number;

        public override string ToString() => $"[Trouble {_number}]";
       
    }
}
