using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PipeR
{
    public class PipeSystem<T>
    {
        private List<Func<T, Func<Task>, Task>> pipeline = new List<Func<T, Func<Task>, Task>>();

        public PipeSystem<T> Use(IFilter<T> filter)
        {
            pipeline.Add(filter.Filter);
            return this;
        }

        public PipeSystem<T> Use(Func<T, Func<Task>, Task> filter)
        {
            pipeline.Add(filter);
            return this;
        }

        public Func<T, Task<T>> Build()
        {
            Func<T, Task> tmp = null;

            foreach (var f in pipeline.AsEnumerable().Reverse())
            {
                if (tmp == null)
                {
                    tmp = v => f(v, Identity);
                }
                else
                {
                    tmp = ComposeFilter(tmp, f);
                }
            }

            return async x =>
            {
                await tmp(x);
                return x;
            };
        }

        private static Func<T, Task> ComposeFilter(Func<T, Task> fun, Func<T, Func<Task>, Task> f)
        {
            return v => f(v, Apply(fun, v));
        }

        private static Func<Task> Apply(Func<T, Task> fun, T v)
        {
            return () => fun(v);
        }

        private async Task Identity() => await Task.Run(() => { return; });
    }
}
