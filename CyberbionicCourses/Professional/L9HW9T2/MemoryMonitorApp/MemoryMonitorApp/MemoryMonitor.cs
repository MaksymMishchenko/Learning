using System;

namespace MemoryMonitorApp
{
    internal class MemoryMonitor
    {
        private int _size;

        public MemoryMonitor(int size)
        {
            _size = size;
        }

        public bool IsLimitExceeded()
        {
            return _size > GC.GetTotalMemory(false);
        }

        public void WarningMsg(object msg)
        {
            if (IsLimitExceeded())
            {
                Console.WriteLine(msg);
            }
        }
    }
}
