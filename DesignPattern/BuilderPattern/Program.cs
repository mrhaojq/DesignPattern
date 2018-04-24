using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.Construct();
                string result = textBuilder.GetResult();
                WriteLine(result);

                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director hDirector = new Director(htmlBuilder);
                hDirector.Construct();
                string hResult = htmlBuilder.GetResult();
                WriteLine(hResult);

                ReadKey();
            }
            catch (Exception ex)
            {

                //throw;
            }
            
        }
    }
}
