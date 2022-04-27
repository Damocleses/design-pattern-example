using design_pattern_example.patterns.constructures;
using design_pattern_example.services;
using System;

namespace design_pattern_example.runners.constructure
{
    public class AdapterRunner : AbstractRunner,IRunner
    {
        public new void Run()
        {
            var americanElectric = new AmericanElectrictService();
            var electric = americanElectric.Get110VElectric();
            Console.WriteLine($"获得了{electric}V电压");
            Console.WriteLine("使用适配器");
            var adapter = new AdapterPattern(americanElectric);
            electric = adapter.Get220VElectric();
            Console.WriteLine($"使用适配器后获得了{electric}V电压");
        }
    }
}
