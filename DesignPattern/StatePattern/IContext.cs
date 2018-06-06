using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
   public interface IContext
    {
        void SetClock(int hour);
        void ChangeState(IState state);
        void CallSecurityCenter(string msg);
        void RecordLog(string msg);
    }
}
