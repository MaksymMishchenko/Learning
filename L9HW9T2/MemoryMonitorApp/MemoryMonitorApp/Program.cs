using System;
using System.Threading;

namespace MemoryMonitorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer(new MemoryMonitor(100000000).WarningMsg, "Memory limit is Exceeded!", 0, 200);

            MyArray[] array = new MyArray[1500];

            for (int i = 0; i < array.Length; i++)
            {
                new MyArray().ShowProgress(i);
            }

            timer.Dispose();

            Console.ReadKey();
        }
    }
}
