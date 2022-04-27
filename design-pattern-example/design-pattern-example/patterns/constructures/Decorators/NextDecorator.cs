using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.constructures.Decorators
{
    public class NextDecorator : PreDecorator
    {
        public NextDecorator(AbstractStudent student) : base(student)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("学习辛苦啦，奖励自己一包辣条");
        }
    }
}
