using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Hand
    {
        public static readonly int HANDVALUE_GUU = 0;//表示石头的值
        public static readonly int HANDVALUE_CHO = 1;//表示剪刀的值
        public static readonly int HANDVALUE_PAA = 2;//表示布的值

        public static readonly Hand[] hand ={
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA)
        };

        private static readonly string[] name = {
            "石头","剪刀","布"
        };

        private int _handvalue = 0;
        /// <summary>
        /// 私有构造方法 拒绝外部通过new关键字创建实例 singleton模式
        /// </summary>
        /// <param name="handvalue"></param>
        private Hand(int handvalue)
        {
            _handvalue = handvalue;
        }

        public static Hand GetHand(int handvalue)
        {
            return hand[handvalue];
        }

        //如果this胜了返回True
        public bool IsStrongerThan(Hand hand)
        {
            return Fight(hand) == 1;
        }

        public bool IsWeakerThan(Hand hand)
        {
            return Fight(hand) == -1;
        }

        private int Fight(Hand hand)
        {
            if (this==hand)
            {
                return 0;
            }
            else if ((this._handvalue+1)%3==hand._handvalue)//?hand._handvalue(private property a)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return name[_handvalue];
        }
    }
}
