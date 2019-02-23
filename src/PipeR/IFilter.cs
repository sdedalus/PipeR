using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PipeR
{
    public interface IFilter<T>
    {
        Task Filter(T value, Func<Task> next);
    }
}
