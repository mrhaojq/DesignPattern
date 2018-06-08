using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ProxyPattern
{
    public class Printer : IPrintable
    {
        private string _name;

        public Printer(string name)
        {
            _name = name;
            HeavyJob($"Printer 的示例生成中 {_name} ");
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string msg)
        {
            WriteLine($"=== {_name} ===");
            WriteLine(msg);
        }

        public void SetPrinterName(string name)
        {
            _name = name;
        }

        private void HeavyJob(string msg)
        {
            WriteLine(msg);
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
            WriteLine("结束");
        }
    }
}
