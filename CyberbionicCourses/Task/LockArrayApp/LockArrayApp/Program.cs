using System;

namespace LockArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primary thread is starting");
            int[] arr = { 1, 2, 3, 4, 5 };

            MyThread thread1 = new MyThread("First Thread", arr);
            MyThread thread2 = new MyThread("Second Thread", arr);

            thread1.GetMyThread.Join();
            thread2.GetMyThread.Join();
        }
    }
}
