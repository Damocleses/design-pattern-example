using design_pattern_example.patterns.creators;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.runners.creators
{
    public class AbstractFactoryRunner : IRunner
    {
        public void Run()
        {
            Console.WriteLine("使用抽象工厂 DellAbstractFactory 创建产品");
            var dellFactory = new DellAbstractFactory();
            dellFactory.CreateKeyboard().Click();
            dellFactory.CreateMouse().Click();

            Console.WriteLine("使用抽象工厂 HpAbstractFactory 创建产品");
            var hpFactory = new HpAbstractFactory();
            hpFactory.CreateKeyboard().Click();
            hpFactory.CreateMouse().Click();
        }
    }
}
