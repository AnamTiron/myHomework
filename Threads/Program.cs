using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Threads.Tasks;

namespace Threads
{
    class Program
    {
        private static void Main()
        {
            //Threads examples
            //ThreadTest.Execute();
            //SharringDataTest.Execute();
            //LockerObjectTest.Execute();
            //JoinSleepTest.Execute();
            //CreatingAndStartingThreads.Execute();


            //ThreadPoolTest.Execute();

            //Tasks examples
            //SimpleDownloadingStringTask.Execute();
            SimpleAsyncDownloadingString.Execute();


            //TasksTest.Execute();
        }
    }

}
