using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.entities
{
    public class DellMouse : IMouse
    {
        public void Click()
        {
            Console.WriteLine("戴尔鼠标点击事件");
        }
    }
}
