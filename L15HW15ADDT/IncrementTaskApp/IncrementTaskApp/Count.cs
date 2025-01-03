using System;
using System.Threading;
using System.Threading.Tasks;

namespace IncrementTaskApp
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
                    Console.WriteLine($"Counter: {++_counter}, thread: {Thread.CurrentThread.ManagedThreadId}");
                }
            }
        }

        public async void DoIncrementAsync()
        {
            await Task.Factory.StartNew(DoIncrement);
        }
    }
}
