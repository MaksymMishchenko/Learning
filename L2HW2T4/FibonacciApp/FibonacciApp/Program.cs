using System;
using System.Threading;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main started Current thread: {Thread.CurrentThread.ManagedThreadId}");

            Task<double> task = new Task<double>(() => FindLastFibonacciNumber(10), TaskCreationOptions.LongRunning);
            task.Start();

            task.ContinueWith((t) =>
            {
                Console.WriteLine($"Last fibonacci digit: {t.Result}");
            });

            Console.WriteLine($"Main finished Current thread: {Thread.CurrentThread.ManagedThreadId}");

            Console.ReadKey();
        }

        private static double FindLastFibonacciNumber(int number)
        {
            Console.WriteLine($"FindLastFibonacciNumber started Current thread: {Thread.CurrentThread.ManagedThreadId}");
            Func<int, double> fib = null;
            fib = (x) => x > 1 ? fib(x - 1) + fib(x - 2) : x;
            Console.WriteLine($"FindLastFibonacciNumber finished Current thread: {Thread.CurrentThread.ManagedThreadId}");
            return fib.Invoke(number);
        }
    }
}
