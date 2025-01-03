using System;
using System.Collections.Generic;
using System.Threading;

namespace MemoryCleanerApp
{
    internal class LargeObject : IDisposable
    {
        private List<LargeObject> _list;
        private bool _disposing = false;

        public int Count => _list.Count;

        public LargeObject()
        {
            _list = new List<LargeObject>();
        }

        public void Add(LargeObject obj)
        {
            _list.Add(obj);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (!_disposing)
            {
                if (dispose)
                {
                    Console.WriteLine("Release of resources:");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(100);
                    }

                    Console.WriteLine("\nResources have been released!");
                }
            }

            _disposing = true;
        }
    }
}
