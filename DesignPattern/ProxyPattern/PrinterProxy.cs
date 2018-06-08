using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class PrinterProxy : IPrintable
    {
        private string _name;
        private Printer real;

        public PrinterProxy()
        { }

        public PrinterProxy(string name)
        {
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string msg)
        {
            Realize();
            real.Print(msg);
        }

        public void SetPrinterName(string name)
        {
            if (real!=null)
            {
                real.SetPrinterName(name);
            }
            _name = name;
        }

        private void Realize()
        {
            if (real==null)
            {
                real = new Printer(_name);
            }
        }
    }
}
