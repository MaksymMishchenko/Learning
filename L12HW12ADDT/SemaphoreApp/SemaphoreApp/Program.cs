using System;
using System.IO;
using System.Threading;

namespace SemaphoreApp
{
    class Program
    {
        private static Semaphore pool = null;

        public static void WriteLog(object name)
        {
            pool.WaitOne();
            File.AppendAllText("log.txt", $"Method WriteLog was started in thread: {name}\n");
            Thread.Sleep(500);
            File.AppendAllText("log.txt", $"Method WriteLog was finished in thread: {name}\n");
            pool.Release();
        }

        static void Main(string[] args)
        {
            pool = new Semaphore(1, 3);

            for (int i = 0; i < 8; i++)
            {
                new Thread(WriteLog).Start(i);
            }
        }
    }
}
