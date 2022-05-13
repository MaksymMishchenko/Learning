using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskSchedulerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Method Main is started in Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            StackTaskScheduler scheduler = new StackTaskScheduler();

            for (int i = 0; i < 5; i++)
            {
                new Task(() =>
                {
                    Console.WriteLine($"Task {Task.CurrentId} is finished.");
                    Thread.Sleep(1000);

                }).Start(scheduler);
            }

            Console.ReadKey();
        }
    }
}
