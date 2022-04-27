using design_pattern_example.common;
using design_pattern_example.runners;
using design_pattern_example.runners.constructure;
using design_pattern_example.runners.constructurers;
using design_pattern_example.runners.creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.factories
{
    public class PatternFactory
    {
        public static IRunner CreateRunner(PatternEnum pattern) =>
            pattern switch
            {
                PatternEnum.Singleton => new SingletonRunner(),
                PatternEnum.Prototype => new PrototypeRunner(),
                PatternEnum.Factory_Method => new FactoryMethodRunner(),
                PatternEnum.Abstract_Factory => new AbstractFactoryRunner(),
                PatternEnum.Adapter => new AdapterRunner(),
                PatternEnum.Decorator => new DecoratorRunner(),
                PatternEnum.Bridge => new BridgeRunner(),
                _ => throw new Exception("No Runner found.")
            };
    }
}
