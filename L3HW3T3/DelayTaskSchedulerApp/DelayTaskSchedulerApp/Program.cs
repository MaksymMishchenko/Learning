using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelayTaskSchedulerApp
{
    class Program
    {
        public static void ShowMsg()
        {
            Console.WriteLine($"\nTask run in thread: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Task Run in ThreadPool: {Thread.CurrentThread.IsThreadPoolThread}");
        }

        static void Main(string[] args)
        {
            var scheduler = new DelayTaskScheduler();
            Task task = new Task(ShowMsg);
            task.Start(scheduler);

            while (task.IsCompleted == false)
            {
                Console.Write($"* ");
                Thread.Sleep(100);
            }
        }
    }
}
