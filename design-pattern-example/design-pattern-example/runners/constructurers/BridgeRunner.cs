using System;
using System.Collections.Generic;
using System.Text;
using static design_pattern_example.errExample.BridgePatterErrorExample;

namespace design_pattern_example.runners.constructurers
{
    public class BridgeRunner : IRunner
    {
        public void Run()
        {
            var bigHotMilkTeaBuilder = new BigMilkTeaBuilder(new HotTemperatureBuilder());
            var bigHotMilkTea = bigHotMilkTeaBuilder.OrderMilkTea();
            bigHotMilkTea.ShowMilkTeaInfo();
        }
    }
}
