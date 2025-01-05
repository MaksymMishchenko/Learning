using System;
using System.Threading;

namespace ThreadWrapperApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Method Main is started in thread Id: {Thread.CurrentThread.ManagedThreadId}");

            var threadWorker = new ThreadWorker(WriteChar);
            threadWorker.Start('*');

            for (int i = 0; i < 160; i++)
            {
                Console.Write('#');
                Thread.Sleep(100);
            }

            threadWorker.Wait();
            Console.WriteLine($"Method Main is finished in thread Id: {Thread.CurrentThread.ManagedThreadId}");

            Console.ReadKey();
        }

        private static void WriteChar(object obj)
        {
            Console.WriteLine($"Method WriteChar is started in thread Id: {Thread.CurrentThread.ManagedThreadId}");
            char value = (char)obj;

            for (int i = 0; i < 160; i++)
            {
                Console.Write(value);
                Thread.Sleep(100);
            }

            Console.WriteLine($"Method WriteChar is finished in thread Id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
