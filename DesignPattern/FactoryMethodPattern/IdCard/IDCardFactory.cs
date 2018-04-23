using FactoryMethodPattern.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.IdCard
{
    public class IDCardFactory : Factory
    {
        private List<String> _owners = new List<String>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add(((IDCard)product).GetOwner());
        }

        public List<string> GetOwners()
        {
            return _owners;
        }
    }
}
