using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ChainOfResponsibilityPattern
{
    public abstract class Support
    {
        private string _name;
        private Support _next;
        public Support(string name)
        {
            _name = name;
        }

        public Support SetNext(Support next)
        {
            _next = next;
            return next;
        }

        public void SupportTrouble(Trouble trouble)
        {
            if (Resolve(trouble))
            {
                Done(trouble);
            }
            else if(_next!=null)
            {
                _next.SupportTrouble(trouble);
            }
            else
            {
                Fail(trouble);
            }
        }

        protected abstract bool Resolve(Trouble trouble);

        protected void Done(Trouble trouble)
        {
            WriteLine($"{trouble} is resolved by {this}");
        }

        protected void Fail(Trouble trouble)
        {
            WriteLine($"{trouble} cannot be resolved.");
        }

        public override string ToString()
        {
            return $"[{_name}]";
        }
    }
}
