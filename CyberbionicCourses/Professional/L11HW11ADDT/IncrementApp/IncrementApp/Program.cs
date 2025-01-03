using System;
using System.Threading;

namespace IncrementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key no increment...");
            Console.ReadKey();

            Thread[] threads = new Thread[3];

            for (int i = 0; i < threads.Length; i++)
                threads[i] = new Thread(new Count().DoIncrement);

            for (int i = 0; i < threads.Length; i++)
                threads[i].Start();
        }
    }
}
