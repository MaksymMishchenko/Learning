using System;
using System.Threading;
using System.Threading.Tasks;

namespace WriteSymbolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main is started in thread id: {Thread.CurrentThread.ManagedThreadId}");

            Task task = new Task(WriteChar, '!');
            task.Start();

            while (!task.IsCompleted)
            {
                Console.Write('$');
                Thread.Sleep(100);
            }

            Console.WriteLine($"Main is finished in thread id: {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadKey();
        }

        private static void WriteChar(object symbol)
        {
            Console.WriteLine($"WriteChar is started in thread id: {Thread.CurrentThread.ManagedThreadId}, Task id: {Task.CurrentId}");
            char value = (char)symbol;

            for (int i = 0; i < 160; i++)
            {
                Console.Write(value);
                Thread.Sleep(200);
            }

            Console.Write('\n');
            Console.WriteLine($"WriteChar is finished in thread id: {Thread.CurrentThread.ManagedThreadId}, Task id: {Task.CurrentId}");
        }
    }
}
