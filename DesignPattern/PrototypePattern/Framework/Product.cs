using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Framework
{
   public interface Product
    {
        void Use(string s);
        Product CreateClone();
    }
}
