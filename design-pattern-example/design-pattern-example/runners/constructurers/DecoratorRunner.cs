using design_pattern_example.entities;
using design_pattern_example.patterns.constructures;
using design_pattern_example.patterns.constructures.Decorators;
using design_pattern_example.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.runners.creators
{
    public class DecoratorRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine("没有用装饰器的基本功能：");
            var student = new Student();
            student.Study();
            Console.WriteLine();

            Console.WriteLine("使用前缀装饰器在基础功能之前做点什么");
            var preDecorator = new PreDecorator(student);
            preDecorator.Study();
            Console.WriteLine();
            Console.WriteLine("使用后缀装饰器在前缀装饰器功能之后做点什么");
            var nextDecorator = new NextDecorator(student);
            nextDecorator.Study();
        }
    }
}
