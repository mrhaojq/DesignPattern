using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class DayState : IState
    {
        private static DayState singleton = new DayState();

        private DayState()
        { }

        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("按下警铃（白天）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (hour>9||17<=hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("正常通话（白天）");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("使用金库（白天）");
        }

        public override string ToString()
        {
            return "[白天]";
        }
    }
}
