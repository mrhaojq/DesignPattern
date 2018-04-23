using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Framework;

namespace FactoryMethodPattern.TV
{
    public class Televison : Product
    {
        private string _tvname;

        public Televison(string tvname)
        {
            _tvname = tvname;
        }

        public override void Use()
        {
            Console.WriteLine($"打开 {_tvname} 观看节目。");
        }

        public string GetTelevsionName()
        {
            return _tvname;
        }
    }
}
