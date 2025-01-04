using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockArrayApp
{
    class MyThread
    {
        private Thread _myThread;
        private int _answer;
        private int[] _arr;

        public Thread GetMyThread
        {
            get { return _myThread; }
        }

        private static SumArray sum = new SumArray();

        public MyThread(string name, int[] arr)
        {
            _arr = arr;
            _myThread = new Thread(Run);
            _myThread.Name = name;
            _myThread.Start();
        }

        public void Run()
        {
            Console.WriteLine("Thread is starting");
            _answer = sum.GetSum(_arr);
            Console.WriteLine($"Now work {_myThread.Name} result - {_answer}");
            Console.WriteLine("Thread is finished");
        }
    }
}
