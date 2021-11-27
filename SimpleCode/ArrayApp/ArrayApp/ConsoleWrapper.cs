using System;

namespace ArrayApp
{
    public class ConsoleWrapper : IConsole
    {
        public void WriteLine(in int num)
        {
            Console.WriteLine($"{num}\t");
        }

        public void Write(in int num)
        {
            Console.Write($"{num}\t");
        }
    }
}