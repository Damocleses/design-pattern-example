using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.constructures.Decorators
{
    public abstract class BaseDecorator : AbstractStudent
    {
        protected readonly AbstractStudent _student;
        public BaseDecorator(AbstractStudent student)
        {
            this._student = student;
        }
        public override void Study()
        {
            this._student.Study();
        }
    }
}
