using design_pattern_example.common;
using System;

namespace design_pattern_example.runners
{
    internal class RunnerRegisterAttribute : Attribute
    {
        public PatternEnum PatternEnum { get; set; }
        public RunnerRegisterAttribute(PatternEnum patternEnum)
        {
            this.PatternEnum = patternEnum;
        }
    }
}