using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.services
{
    public class AmericanElectrictService : IAmericanElectrictService
    {
        public int Get110VElectric()
        {
            Console.WriteLine("美国的电压是110v，只能提供110V的电压");
            return 110;
        }
    }
}
