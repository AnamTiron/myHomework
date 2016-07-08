using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threads
{
    public class ThreadTest
    {
        public static void Execute()
        {
            Thread t = new Thread(Write0);          // Kick off a new thread
            t.Start();                               // running WriteY()

            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++) Console.Write("X");

            Console.ReadKey();
        }

        static void Write0()
        {
            for (int i = 0; i < 1000; i++) Console.Write("0");
        }
    }
}
