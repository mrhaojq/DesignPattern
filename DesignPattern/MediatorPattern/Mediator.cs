using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
   public interface Mediator
    {
        void CreateColleagues();
        void ColleagueChanged();
    }
}
