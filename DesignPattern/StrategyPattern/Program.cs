using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

          
            WriteLine("RNGCryptoServiceProvider Class");
            for (int i = 0; i < 10; i++)
            {
                WriteLine(RandomNumberHelper.GetRandomInt());
            }

            WriteLine( "不靠谱的 Random Class");
            for (int i = 0; i < 10; i++)
            {
                WriteLine(new Random().Next(int.MaxValue));
                Thread.Sleep(100);//加上Sleep靠谱点了
            }
            ReadKey();

            Player player1 = new Player("Taro", new WinningStrategy(315));
            Player player2 = new Player("Nana",new ProbStrategy(15));

            for (int i = 0; i < 1000; i++)
            {
                Hand nextHand1 = player1.NextHand();
                Thread.Sleep(100);//Random 并不能产生可靠的随机数，添加sleep使cpu切换到其他进程，尽量保证随机性
                Hand nextHand2 = player2.NextHand();

                if (nextHand1.IsStrongerThan(nextHand2))
                {
                    Console.WriteLine($"Winner:{player1}");
                    player1.Win();
                    player2.Lose();
                }
                else if (nextHand2.IsStrongerThan(nextHand1))
                {
                    Console.WriteLine($"Winner:{player2}");
                    player1.Lose();
                    player2.Win();
                }
                else
                {
                    Console.WriteLine($"Even...");
                    player1.Even();
                    player2.Even();
                }
            }

            Console.WriteLine($"Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());

            Console.ReadKey();
        }
    }
}
