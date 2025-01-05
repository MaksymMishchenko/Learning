using System;
using System.Threading;

namespace WriterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var autoResetEvent = new AutoResetEvent(false);
            var thread = new Writer("First", autoResetEvent);
            autoResetEvent.WaitOne();

            Console.WriteLine("Method Main continue working");

            var thread1 = new Writer("Second", autoResetEvent);
            autoResetEvent.WaitOne();

            Console.WriteLine("Method Main is finished");
        }
    }
}
