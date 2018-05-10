using System;
using static System.Console;


namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Display b1 = new StringDisplay("Hello,world.");
            Display b2 = new SideBorder(b1, '#');
            Display b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();

            Display b4 = new SideBorder(
                new FullBorder(
                    new FullBorder(
                        new SideBorder(
                            new StringDisplay("你好，世界。")
                            , '*')
                            )
                        )
                , '/');

            b4.Show();

            ReadKey();
        }
    }
}
