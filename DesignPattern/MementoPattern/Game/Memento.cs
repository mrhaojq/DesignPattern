using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Game
{
    public class Memento
    {
        int money;
        List<string> fruits;

        public Memento(int money)
        {
            this.money = money;
            this.fruits = new List<string>();
        }

        public int GetMoney()
        {
            return money;
        }

        public void AddFruit(string fruit)
        {
            fruits.Add(fruit);
        }

        public List<string> GetFruits()
        {
            //string[] fruitsCopy = new string[fruits.Count];
            //fruits.c
            return fruits; ;
        }

    }
}
