using design_pattern_example.common;
using design_pattern_example.factories;
using design_pattern_example.patterns.creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_pattern_example.runners.creators
{
    [RunnerRegister(PatternEnum.Factory_Method)]
    public class FactoryMethodRunner : IRunner
    {
        public void Run()
        {

            var dic = StaticMethod.GetPropertyValueDic(typeof(BrandEnum));
            Console.WriteLine("\nPlease select show brand:");
            dic.Keys.ToList().ForEach(key =>
            {
                Console.WriteLine($"value:{key}, pattern: {dic[key]}");
            });
            var brandStr = Console.ReadLine();
            var brandEnum = 0;
            Int32.TryParse(brandStr, out brandEnum);
            var mouseFactory = MouseFactory.CreateMouseFactory((BrandEnum)brandEnum);

            var mouse = mouseFactory.CreateMouse();

            mouse.Click();

        }
    }
}
