using System;
using System.Threading;

namespace ThreadWrapperApp
{
    class ThreadWorker<TResult>
    {
        private readonly Func<object, TResult> _func;
        private TResult _result;
        public ThreadWorker(Func<object, TResult> func)
        {
            _func = func ?? throw new ArgumentNullException();
        }

        public bool IsSuccess { get; set; } = false;
        public bool IsCompleted { get; set; } = false;
        public Exception Exception { get; set; } = null;

        public TResult GetResult
        {
            get
            {
                while (IsCompleted != true)
                {
                    Thread.Sleep(100);
                }

                return _result;
            }
        }

        public void Start(object obj)
        {
            var thread = new Thread(ThreadExecute);
            thread.Start(obj);
        }

        public void ThreadExecute(object? obj)
        {
            try
            {
                _result = _func.Invoke(obj);
                IsSuccess = true;
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
    }
}
