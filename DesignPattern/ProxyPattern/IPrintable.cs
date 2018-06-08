using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public interface IPrintable
    {
        void SetPrinterName(string name);
        string GetPrinterName();
        void Print(string msg);
    }
}
