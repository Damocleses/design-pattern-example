using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.creators
{
    public class PrototypePattern
    {
        private static PrototypePattern _protetypeInstance = new PrototypePattern();

        private PrototypePattern()
        {

        }

        public static PrototypePattern GetInstance()
        {
            PrototypePattern clone = (PrototypePattern)_protetypeInstance.MemberwiseClone();
            return clone;
        }
    }
}
