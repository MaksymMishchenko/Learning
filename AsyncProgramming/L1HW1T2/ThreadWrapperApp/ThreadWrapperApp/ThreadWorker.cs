using System;
using System.Threading;

namespace ThreadWrapperApp
{
    class ThreadWorker
    {
        private readonly Action<object> _action;

        public ThreadWorker(Action<object> action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
        }

        public bool IsSuccess { get; private set; } = false;
        public bool IsCompleted { get; private set; } = false;

        public Exception Exception { get; private set; } = null;

        public void Start(object obj)
        {
            try
            {
                Thread thread = new Thread(_action.Invoke);
                thread.Start(obj);
            }
            catch (Exception ex)
            {
                Exception = ex;
                IsSuccess = false;
            }
            finally
            {
                IsCompleted = true;
            }
        }

        public void Wait()
        {
            while (IsCompleted == false)
            {
                Thread.Sleep(100);
            }

            if (Exception != null)
            {
                throw Exception;
            }
        }
    }
}
