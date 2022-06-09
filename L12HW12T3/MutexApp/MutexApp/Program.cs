using System;
using System.Threading;

namespace MutexApp
{
    class Program
    {
        static Mutex mutex = new Mutex(false, $"MyMytex-{new Guid()}");
        static void Main(string[] args)
        {
            mutex.WaitOne();

            Console.WriteLine($"Method Enter to the safe zone");
            Thread.Sleep(1000);
            Console.WriteLine($"Method Exit to the safe zone");

            Console.ReadKey();

            mutex.ReleaseMutex();
        }
    }
}
