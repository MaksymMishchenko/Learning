using System.Threading;

namespace FileAccessApp
{
    internal class BlockObject
    {
        private int _block;
        private int _wait;

        public BlockObject(int wait)
        {
            _wait = wait;
        }

        public void Enter()
        {
            int result = Interlocked.CompareExchange(ref this._block, 1, 0);

            while (result == 1)
            {
                Thread.Sleep(_wait);
                result = Interlocked.CompareExchange(ref _block, 1, 0);
            }
        }

        public void Exit()
        {
            Interlocked.Exchange(ref _block, 0);
        }
    }
}
