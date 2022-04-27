using design_pattern_example.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.patterns.constructures
{
    public class AdapterPattern : IChineseElectricService
    {
        private readonly IAmericanElectrictService _service;

        public AdapterPattern(IAmericanElectrictService service)
        {
            this._service = service;
        }
        public int Get220VElectric()
        {
            var electric = this._service.Get110VElectric();
            Console.WriteLine("劈里啪啦劈里啪啦，经过一番操作，现在电压转换为220V的了");
            return electric + 110;
        }
    }
}
