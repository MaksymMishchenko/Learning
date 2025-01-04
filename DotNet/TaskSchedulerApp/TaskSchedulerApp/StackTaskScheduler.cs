using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskSchedulerApp
{
    internal class StackTaskScheduler : TaskScheduler
    {
        private readonly Stack<Task> _tasks = new Stack<Task>();

        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return _tasks;
        }

        protected override void QueueTask(Task task)
        {
            _tasks.Push(task);
            Console.WriteLine($"Task with id {task.Id} was added");
            RunTasksFromStack();
        }

        public void RunTasksFromStack()
        {
            Task nextTask = null;

            if (_tasks.Count == 5)
            {
                while (_tasks.Count != 0)
                {
                    nextTask = _tasks.Pop();

                    TryExecuteTask(nextTask);
                }
            }
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return TryExecuteTask(task);
        }
    }
}
