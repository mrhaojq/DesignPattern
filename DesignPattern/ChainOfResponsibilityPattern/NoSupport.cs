using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class NoSupport : Support
    {
        public NoSupport(string name)
            : base(name)
        {

        }

        protected override bool Resolve(Trouble trouble)
        {
            return false;
        }
    }
}
