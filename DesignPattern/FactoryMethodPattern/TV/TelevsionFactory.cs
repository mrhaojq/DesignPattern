using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Framework;
using static System.Console;

namespace FactoryMethodPattern.TV
{
    public class TelevsionFactory : Factory
    {
        private List<string> _tvList = new List<string>(); 

        protected override Product CreateProduct(string owner)
        {
            return new Televison(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _tvList.Add(((Televison)product).GetTelevsionName());
        }
    }
}
