
using System;
using System.Threading;

namespace Threads
{
    public static class CreatingAndStartingThreads
    {
        public static void Execute()
        {
            Thread t1 = new Thread(new ThreadStart(Go));
            t1.Start();
            Thread t2 = new Thread(Go);
            t2.Start();
            Thread t3 = new Thread(() => Console.WriteLine("hello! threadNo: " + Thread.CurrentThread.ManagedThreadId));
            t3.Start();

            Go();

            Console.ReadKey();
        }

        private static void Go()
        {
            Console.WriteLine("hello! threadNo: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
