using System;
using System.Threading;

namespace LockArrayApp
{
    class SumArray
    {
        private object obj = new object();
        
        public int GetSum(int[] arr)
        {
            lock (obj)
            {
                int temp = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    temp += arr[i];
                    Console.WriteLine($"Current sum {temp} for thread {Thread.CurrentThread.Name}");
                }

                return temp;
            }
        }
    }
}
