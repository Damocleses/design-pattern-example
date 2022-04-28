using design_pattern_example.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace design_pattern_example.runners
{
    public class RunnerContext
    {
        private static readonly Dictionary<PatternEnum, IRunner> mappers = new Dictionary<PatternEnum, IRunner>();

        public static void RegisterRunner(PatternEnum pattern,IRunner runner)
        {
            mappers.Add(pattern, runner);
        }

        public static IRunner GetRunner(PatternEnum pattern)
        {
           return mappers.GetValueOrDefault(pattern);
        }

        public static void RegisterAllRunners(string assemblyPath)
        {
            var assemble = Assembly.Load(assemblyPath);
            assemble.GetExportedTypes()
                .Where(i => i.IsClass && i.GetCustomAttribute<RunnerRegisterAttribute>() != null)
                .ToList()
                .ForEach(i =>
                {
                    var attr = i.GetCustomAttribute<RunnerRegisterAttribute>();
                    var hasAttribute = attr != null;
                    Console.WriteLine($"name:{i.Name}, has attr: {hasAttribute}");
                    RegisterRunner(attr.PatternEnum, (IRunner)assemble.CreateInstance(i.FullName));
                });
        }

    }
}
