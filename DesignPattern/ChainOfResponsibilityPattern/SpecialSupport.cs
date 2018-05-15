using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class SpecialSupport : Support
    {
        private int _number;
        public SpecialSupport(string name, int number)
            :base(name)
        {
            _number = number;
        }

        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNumber()==_number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
