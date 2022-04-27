using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.constructures.Decorators
{
    public class PreDecorator : BaseDecorator
    {
        public PreDecorator(AbstractStudent student) : base(student)
        {
        }

        public override void Study()
        {
            Console.WriteLine("学习前看会儿小说");
            base.Study();
        }
    }
}
