using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Tasks
{
    public static class SimpleDownloadingStringTask
    {
        public static void Execute()
        {
            // Start the task executing:
            Task<string> task = Task.Factory.StartNew<string>(() => DownloadString("http://www.teamnet.ro/"));

            // We can do other work here and it will execute in parallel:

            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            // When we need the task's return value, we query its Result property:
            // If it's still executing, the current thread will now block (wait)
            // until the task finishes:
            string result = task.Result;
            Console.WriteLine(result);
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            Console.ReadKey();
        }

        private static string DownloadString(string uri)
        {
            Thread.Sleep(5000);

            using (var wc = new System.Net.WebClient())
                return wc.DownloadString(uri);
        }
    }
}
