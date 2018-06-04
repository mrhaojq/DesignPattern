using System;
using System.Threading;
using MementoPattern.Game;
using static System.Console;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento Pattern");
            Gamer gamer = new Gamer(100);
            Memento memento = gamer.CreateMemento();//保存最初状态
            for (int i = 0; i < 100; i++)
            {
                WriteLine($"==== {i+1}");
                WriteLine($"当前状态：{gamer}");

                gamer.Bet();

                WriteLine($"所持金钱为：{gamer.GetMoney()}");

                //决定如何处理
                if (gamer.GetMoney()>memento.GetMoney())
                {
                    WriteLine($"(所持金钱增加了许多，因此保存游戏当前的状态)");
                    memento = gamer.CreateMemento();
                }
                else if(gamer.GetMoney()<memento.GetMoney()/2)
                {
                    WriteLine($"(所持金钱减少了许多，因此将游戏恢复至以前的状态)");
                    gamer.RestoreMemento(memento);
                }

                Thread.Sleep(100);
                WriteLine();
            }

            ReadKey();
        }
    }
}
