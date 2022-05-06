using System;
using System.Threading;

namespace PrintSymbolsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((WriteChar), '*');

            for (int i = 0; i < 160; i++)
            {
                Console.Write('#');
                Thread.Sleep(100);
            }
        }

        private static void WriteChar(object symbol)
        {
            char value = (char)symbol;

            for (int i = 0; i < 160; i++)
            {
                Console.Write(value);
                Thread.Sleep(100);
            }
        }
    }
}
