using System;
using static System.Console;
namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProxyPattern");
            IPrintable proxy = new PrinterProxy("Alice");

            WriteLine($"现在的名字是{proxy.GetPrinterName()}.");

            proxy.SetPrinterName("Bob");

            WriteLine($"现在的名字是{proxy.GetPrinterName()}.");

            proxy.Print("Hello World!");

            //只有需要调用Print的时候才生成Printer的实例，
            //在调用Print之前（生成实例之前） 可以调用代理的其他方法，间接模拟调用尚未初始化的Printer中的其他方法
            ReadKey();
        }
    }
}
