using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.runners
{
    public class AbstractRunner : IRunner
    {
        public AbstractRunner()
        {
            RunnerContext.RegisterRunner(this.GetType().Name, this);
        }

        public void Run()
        {
        }
    }
}
