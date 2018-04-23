using FactoryMethodPattern.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.IdCard;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //屏蔽了IDCard类 通过IDCardFactory 创建IDCard类的实例
            //面向抽象编程，抽象接口的实例指向IDCardFactory具体类
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("小明");
            Product card2 = factory.Create("小红");
            Product card3 = factory.Create("小刚");
            card1.Use();
            card2.Use();
            card3.Use();


            ////面向具体类编程
            //IDCardFactory factory2 = new IDCardFactory();
            //IDCard card11 = (IDCard)factory2.Create("小明");
            //IDCard card22 = (IDCard)factory2.Create("小红");
            //IDCard card33 = (IDCard)factory2.Create("小刚");
            //card11.Use();
            //card22.Use();
            //card33.Use();


            Console.ReadKey();
        }
    }
}
