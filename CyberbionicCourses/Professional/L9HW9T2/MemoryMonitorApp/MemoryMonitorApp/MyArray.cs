using System;

namespace MemoryMonitorApp
{
    internal class MyArray
    {
        private Array array = new int[100000000];

        public void ShowProgress(int i)
        {
            Console.WriteLine(i);
        }
    }
}
