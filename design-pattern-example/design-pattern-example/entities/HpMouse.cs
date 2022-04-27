using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.entities
{
    public class HpMouse : IMouse
    {
        public void Click()
        {
            Console.WriteLine("惠普鼠标点击事件");
        }
    }
}
