using System;
using System.Threading;
using System.Threading.Tasks;

namespace WriteCharApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '*';
            ThreadPool.QueueUserWorkItem(new WaitCallback(ConsoleWriter), symbol);

            for (int i = 0; i < 160; i++)
            {
                Console.Write("!");
                Thread.Sleep(100);
            }
        }

        private static void ConsoleWriter(object obj)
        {
            char symbol = (char)obj;

            for (int i = 0; i < 160; i++)
            {
                Console.Write(symbol);
                Thread.Sleep(100);
            }
        }
    }
}
