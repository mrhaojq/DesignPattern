using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class LimitSupport : Support
    {
        private int _limit;
        public LimitSupport(string name, int limit)
            : base(name)
        {
            _limit = limit;
        }

        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNumber() < _limit)
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
