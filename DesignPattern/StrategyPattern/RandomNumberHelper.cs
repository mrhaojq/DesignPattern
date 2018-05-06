using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace StrategyPattern
{
     public  class RandomNumberHelper
    {
        public static int GetRandomInt()
        {
            //RNGCryptoServiceProvider 和 RandomNumberGenerator 都是OK的
            byte[] byteCsp = new byte[4];

            //RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();
            //csp.GetBytes(byteCsp);

            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            generator.GetBytes(byteCsp);

            int number = BitConverter.ToInt32(byteCsp,0);
            return number;
            //Console.WriteLine(BitConverter.ToString(byteCsp));
        }
    }
}
