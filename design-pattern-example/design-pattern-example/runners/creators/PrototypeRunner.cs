using design_pattern_example.patterns.creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.runners.creators
{
    public class PrototypeRunner : IRunner
    {
        public void Run()
        {
            var s1 = PrototypePattern.GetInstance();
            var s2 = PrototypePattern.GetInstance();
            Console.WriteLine($"原型模式创建对象，s1 == s2: {s1.Equals(s2)}");
        }
    }
}
