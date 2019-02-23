using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PipeR
{
    public abstract class Filter<T> : IFilter<T>
    {
        private Func<Task> next;

        Task IFilter<T>.Filter(T value, Func<Task> next)
        {
            this.next = next;
            return this.Action(value);
        }

        protected abstract Task Action(T Value);

        protected Task Next()
        {
            return this.next();
        }
    }
}
