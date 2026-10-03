using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            int loopCount = 0;
            Thread thread = Thread.CurrentThread;

            while (loopCount <= 5)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                loopCount++;
                Thread.Sleep(1500);

            }
        }

    }
}
