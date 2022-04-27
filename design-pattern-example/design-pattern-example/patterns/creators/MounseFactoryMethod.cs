using design_pattern_example.common;
using design_pattern_example.entities;
using design_pattern_example.Interface;
using design_pattern_example.runners;
using design_pattern_example.runners.creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.creators
{
    public abstract class MounseFactoryMethod
    {
        public abstract IMouse CreateMouse();
    }

    public class DellMouseFactory : MounseFactoryMethod
    {
        public override IMouse CreateMouse()
        {
            return new DellMouse();
        }
    }

    public class HpMouseFactory : MounseFactoryMethod
    {
        public override IMouse CreateMouse()
        {
            return new HpMouse();
        }
    }
}
