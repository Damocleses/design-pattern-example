using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.entities
{
    public class DellKeyboard : IKeyboard
    {
        public void Click()
        {
            Console.WriteLine("戴尔键盘点击事件");
        }
    }
}
