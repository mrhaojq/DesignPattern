using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor Pattern");

            Directory rootDir = new Directory("root");
            Directory binDir = new Directory("bin");
            Directory tmpDir = new Directory("tmp");
            Directory usrDir = new Directory("usr");

            rootDir.Add(binDir);
            rootDir.Add(tmpDir);
            rootDir.Add(usrDir);

            binDir.Add(new File("vi", 10000));
            binDir.Add(new File("latex", 20000));

            rootDir.Accept(new ListVisitor());


            Console.ReadKey();
        }
    }
}
