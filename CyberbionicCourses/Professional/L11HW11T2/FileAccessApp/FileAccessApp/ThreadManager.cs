using System;

namespace FileAccessApp
{
    internal class ThreadManager : IDisposable
    {
        private BlockObject _block;
        public ThreadManager(BlockObject block)
        {
            _block = block;
            _block.Enter();
        }

        public void Dispose()
        {
            _block.Exit();
        }
    }
}
