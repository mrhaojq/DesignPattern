using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class WinningStrategy : Strategy
    {
        Random random;
        bool won = false;
        Hand prevHand;

        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }
        public Hand NextHand()
        {
            if (!won){
                int r = random.Next
            (3);
                prevHand = Hand.GetHand(r);
            }
            return prevHand;
        }

        public void Study(bool win)
        {
            won = win;
        }
    }
}
