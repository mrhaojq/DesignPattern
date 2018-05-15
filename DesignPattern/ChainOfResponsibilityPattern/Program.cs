using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of responsibility pattern.");
            Support alice = new NoSupport("Alice NoSupport");
            Support bob = new LimitSupport("Bob LimitSupport 100", 100);
            Support charlie = new SpecialSupport("Charlie SpecialSupport 429",429);
            Support diana= new LimitSupport("Diana LimitSupport 200", 200);
            Support elmo = new OddSupport("Elmo");
            Support fred = new LimitSupport("Fred LimitSupport 300", 300);

            //形成职责链
            alice.SetNext(bob).SetNext(charlie).SetNext(diana).SetNext(elmo).SetNext(fred);

            for (int i = 0; i < 500; i+=33)
            {
                alice.SupportTrouble(new Trouble(i));
            }

            Console.ReadKey();
        }
    }
}
