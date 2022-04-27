using design_pattern_example.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.entities
{
    public class Student : AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine("我正在学习！！！");
        }
    }
}
