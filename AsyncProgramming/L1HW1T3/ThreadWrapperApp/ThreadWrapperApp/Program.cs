using System;
using System.Threading;

namespace ThreadWrapperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main is started in thread id: {Thread.CurrentThread.ManagedThreadId}");

            var threadWorker = new ThreadWorker<int>(Calculate);
            threadWorker.Start(500);

            while (!threadWorker.IsCompleted)
            {
                Console.Write('!');
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Result: {threadWorker.GetResult}");

            Console.WriteLine($"Main is finished in thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadKey();
        }

        static int Calculate(object sleepTime)
        {
            Console.WriteLine($"Calculate is started in thread id: {Thread.CurrentThread.ManagedThreadId}");

            int sleep = (int)sleepTime;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += i;
                Thread.Sleep(sleep);
            }

            Console.Write('\n');
            Console.WriteLine($"Calculate is finished in thread id: {Thread.CurrentThread.ManagedThreadId}");
            return sum;
        }
    }
}
