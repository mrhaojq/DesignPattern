using System;
using static System.Console;
namespace CompositePattern
{
    class Program
    {
        //容器与内容的一致性
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            try
            {
                WriteLine("Making root entries...");
                Directory rootDir = new Directory("root");
                Directory binDir = new Directory("bin");
                Directory tempDir = new Directory("temp");
                Directory usrDir = new Directory("usr");

                rootDir.Add(binDir);
                rootDir.Add(tempDir);
                rootDir.Add(usrDir);
                binDir.Add(new File("vi",1000));
                binDir.Add(new File("latex", 20000));
                rootDir.PrintList();

                ReadKey();
            }
            catch (FileTreatMentException e)
            {
                WriteLine(e.StackTrace);
            }
        }
    }
}
