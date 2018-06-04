﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
  public  interface Colleague
    {
        void SetMediator(Mediator mediator);
        void SetColleagueEnabled(bool enabled);
    }
}
