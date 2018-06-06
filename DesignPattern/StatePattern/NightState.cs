using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class NightState : IState
    {
        private static NightState singleton = new NightState();

        private NightState()
        { }

        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("按下警铃（晚上）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (9 <=hour&&hour<17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoPhone(IContext context)
        {
            context.RecordLog("晚上的通话录音");
        }

        public void DoUse(IContext context)
        {
            context.CallSecurityCenter("紧急：完善使用金库！");
        }

        public override string ToString()
        {
            return "[晚上]";
        }
    }
}
