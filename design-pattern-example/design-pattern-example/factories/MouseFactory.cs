using design_pattern_example.common;
using design_pattern_example.Interface;
using design_pattern_example.patterns.creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.factories
{
    public class MouseFactory
    {
        public static MounseFactoryMethod CreateMouseFactory(BrandEnum brand)
        {
            switch (brand)
            {
                case BrandEnum.Dell:
                    return new DellMouseFactory();
                case BrandEnum.Hp:
                    return new HpMouseFactory();
                default:
                    return null;
            }
        }
    }
}
