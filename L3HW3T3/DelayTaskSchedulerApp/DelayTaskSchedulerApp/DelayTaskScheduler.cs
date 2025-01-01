using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DelayTaskSchedulerApp
{
    class DelayTaskScheduler : TaskScheduler
    {
        private Queue<Task> queue = new Queue<Task>();
        private AutoResetEvent auto = new AutoResetEvent(false);
        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return Enumerable.Empty<Task>();
        }

        protected override void QueueTask(Task task)
        {
            queue.Enqueue(task);
            WaitOrTimerCallback callBack = (object state, bool timedOut) => { base.TryExecuteTask(queue.Dequeue()); };
            ThreadPool.RegisterWaitForSingleObject(auto, callBack, null, 2000, false);
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false;
        }
    }
}
