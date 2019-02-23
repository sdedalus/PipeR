using PipeR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PipeRTests
{
    public class SkipTestFilter : Filter<TestValue>
    {
        protected override async Task Action(TestValue Value)
        {
            await this.Next();
        }
    }
    public class IncrementTestFilter : Filter<TestValue>
    {
        protected override async Task Action(TestValue Value)
        {
            Value.v++;
            await this.Next();
        }
    }
}
