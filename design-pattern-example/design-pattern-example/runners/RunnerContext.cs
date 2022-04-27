using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.runners
{
    public class RunnerContext
    {
        private static readonly Dictionary<string, IRunner> mappers = new Dictionary<string, IRunner>();

        public static void RegisterRunner(string name,IRunner runner)
        {
            mappers.Add(name, runner);
        }

        public static IRunner GetRunner(string name)
        {
           return mappers.GetValueOrDefault(name);
        }

    }
}
