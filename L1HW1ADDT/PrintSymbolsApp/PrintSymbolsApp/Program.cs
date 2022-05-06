using System;
using System.Threading;

namespace PrintSymbolsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Method Main is started in thread id: {Thread.CurrentThread.ManagedThreadId}");

            ThreadPool.QueueUserWorkItem((WriteChar), '*');

            for (int i = 0; i < 160; i++)
            {
                Console.Write('#');
                Thread.Sleep(100);
            }

            Console.WriteLine($"Method Main is finished in thread id: {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void WriteChar(object symbol)
        {
            Console.WriteLine($"Method WriteChar is started in thread id: {Thread.CurrentThread.ManagedThreadId}.");

            char value = (char)symbol;

            for (int i = 0; i < 160; i++)
            {
                Console.Write(value);
                Thread.Sleep(100);
            }

            Console.WriteLine($"Method WriteChar is finished in thread id: {Thread.CurrentThread.ManagedThreadId}.");
        }
    }
}
