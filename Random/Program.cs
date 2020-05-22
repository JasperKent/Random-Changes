using System;
using System.Threading;

namespace RandomNumbers
{
    class Program
    {
        static void Main()
        {
            Random r1 = new Random(Environment.TickCount);
            Thread.Sleep(10);
            Random r2 = new Random(Environment.TickCount);

            for (int i = 0; i < 10; ++i)
                Console.WriteLine($"{r1.Next(100)}/{r2.Next(100)}");

            //PseudoRandom rand = new PseudoRandom(3421);

            //for (int i = 0; i < 10; ++i)
            //    Console.WriteLine(rand.Next());

        }
    }
}
