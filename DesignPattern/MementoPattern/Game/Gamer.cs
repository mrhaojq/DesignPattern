using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace MementoPattern.Game
{
    public class Gamer
    {
        private int _money;
        private List<string> _fruits;
        private Random _random = new Random();

        private static String[] fruitsName = {
            "苹果","葡萄","香蕉","橘子"
        };

        public Gamer(int money)
        {
            _money = money;
            _fruits = new List<string>();
        }

        public int GetMoney()
        {
            return _money;
        }

        public void Bet()
        {
            int dice = _random.Next(6) + 1;
            if (dice == 1)
            {
                _money += 100;
                WriteLine("所持金钱增加了。");
            }
            else if (dice == 2)
            {
                _money /= 100;
                WriteLine("所持金钱减半了。");
            }
            else if (dice == 6)
            {
                string f = GetFruit();
                WriteLine($"获得了水果 {f}。");
                _fruits.Add(f);
            }
            else
            {
                WriteLine("什么都没发生。");
            }
        }

        private string GetFruit()
        {
            return "好吃的" + fruitsName[_random.Next(fruitsName.Length)];
        }

        public Memento CreateMemento()
        {
            Memento m = new Memento(_money);
            foreach (var item in _fruits)
            {
                m.AddFruit(item);
            }
            return m;
        }

        public void RestoreMemento(Memento memento)
        {
            _money = memento.GetMoney();
            _fruits = memento.GetFruits();
        }

        public override string ToString()
        {
            return $"money={_money},fruits={GetFruitsDetail()}";
        }

        private string GetFruitsDetail()
        {
            StringBuilder fruits = new StringBuilder();
            foreach (var item in _fruits)
            {
                fruits.Append(item+"\t");
            }
            return fruits.ToString();
        }

    }
}
