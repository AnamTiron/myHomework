using System;
using System.Net;

namespace Threads.Tasks
{
    public static class SimpleAsyncDownloadingString
    {
        public static void Execute()
        {
            var wc = new WebClient();
            wc.DownloadStringCompleted += (sender, args) =>
            {
                Console.WriteLine(args.Result.Length + " chars were downloaded");
            };
            wc.DownloadStringAsync(new Uri("http://www.teamnet.ro/"));

            Console.WriteLine("Executing code");
            Console.ReadKey();
        }
    }
}
