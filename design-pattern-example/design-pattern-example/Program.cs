using design_pattern_example.common;
using design_pattern_example.factories;
using Microsoft.Extensions.DependencyInjection;
using design_pattern_example.patterns.creators;
using System;
using System.Linq;
using design_pattern_example.runners;

namespace design_pattern_example
{
    class Program
    {
        static void Main(string[] args)
        {
            RunnerContext.RegisterAllRunners("design-pattern-example");
            var dic = StaticMethod.GetPropertyValueDic(typeof(PatternEnum));
            while (true)
            {
                Console.WriteLine("\nPlease select show patterns:");
                dic.Keys.ToList().ForEach(key =>
                {
                    Console.WriteLine($"value:{key}, pattern: {dic[key]}");
                });
                var patternStr = Console.ReadLine();
                var pattern = 0;
                Int32.TryParse(patternStr, out pattern);
                //var prototype = PatternFactory.CreateRunner((PatternEnum)pattern);
                var prototype = RunnerContext.GetRunner((PatternEnum)pattern);
                Console.WriteLine("------------------------------------");
                prototype.Run();
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
