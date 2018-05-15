﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
   public class OddSupport:Support
    {

        public OddSupport(string name)
            : base(name)
        {

        }

        protected override bool Resolve(Trouble trouble)
        {
            if (trouble.GetNumber()%2==1)
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
