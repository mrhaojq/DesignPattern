using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Framework
{
   public class Manager
    {
        private Dictionary<string, Product> _showcase = new Dictionary<string, Product>();

        public void Register(string name, Product proto)
        {
            if (!_showcase.ContainsKey(name))
            {
                _showcase.Add(name, proto);
            }
            else
            {
                throw new Exception($"Key:{name} 已经注册。");
            }
        }

        //
        public Product Create(string name)
        {
            if (_showcase.ContainsKey(name))
            {
                Product p = (Product)_showcase[name];
                return p.CreateClone();//调用已经注册的克隆方法创建新实例
            }
            else
            {
                throw new Exception($"Key:{name} 未找到。");
            }
        }
    }
}
