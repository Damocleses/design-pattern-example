using design_pattern_example.entities;
using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.creators
{
    public abstract class ComputerAbstractFactory
    {
        public abstract IMouse CreateMouse();
        public abstract IKeyboard CreateKeyboard();
    }

    public class DellAbstractFactory : ComputerAbstractFactory
    {
        public override IKeyboard CreateKeyboard()
        {
            return new DellKeyboard();
        }

        public override IMouse CreateMouse()
        {
            return new DellMouse();
        }
    }

    public class HpAbstractFactory : ComputerAbstractFactory
    {
        public override IKeyboard CreateKeyboard()
        {
            return new HpKeyboard();
        }

        public override IMouse CreateMouse()
        {
            return new HpMouse();
        }
    }
}
