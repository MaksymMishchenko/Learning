using System;
using System.Threading;

namespace IncrementApp
{
    internal class Count
    {
        private static int _counter;
        private static object block = new object();

        public void DoIncrement()
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Interlocked.Increment(ref _counter);
                    Console.WriteLine($"Counter: {_counter}, thread: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }
    }
}
