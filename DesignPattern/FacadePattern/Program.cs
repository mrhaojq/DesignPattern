using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Pattern!");

            PageMaker.MakeWelcomePage("tomura@hyuki.com", "welcome.html");

            Console.ReadKey();
        }
    }
}
