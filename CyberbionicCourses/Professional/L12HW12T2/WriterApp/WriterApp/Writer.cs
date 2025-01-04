using System;
using System.Threading;

namespace WriterApp
{
    class Writer
    {
        private AutoResetEvent _event;
        private Thread _thread;

        public Writer(string name, AutoResetEvent @event)
        {
            _thread = new Thread(this.Write) { Name = name };
            _event = @event;
            _thread.Start();
        }

        public void Write()
        {
            Console.WriteLine($"Write method was started in thread: {Thread.CurrentThread.Name}");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.WriteLine("*");
            }

            Console.WriteLine($"Write method was finished in thread: {Thread.CurrentThread.Name}");
            _event.Set();
        }
    }
}
