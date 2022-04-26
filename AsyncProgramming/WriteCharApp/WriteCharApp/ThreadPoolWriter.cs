using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteCharApp
{
    class ThreadPoolWriter
    {
        private readonly Action<object> _action;

        public ThreadPoolWriter(Action<object> action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action));
        }


    }
}
