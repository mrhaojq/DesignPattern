using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Framework;
using static System.Console;

namespace FactoryMethodPattern.IdCard
{
    public class IDCard : Product
    {
        private string _owner;

        public IDCard(string owner)
        {
            WriteLine($"制作 {owner} 的ID卡。");
            _owner = owner;
        }

        public override void Use()
        {
            WriteLine($"使用 {_owner} 的ID卡。");
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}
