using design_pattern_example.common;
using design_pattern_example.factories;
using Microsoft.Extensions.DependencyInjection;
using design_pattern_example.patterns.creators;
using System;
using System.Linq;
using design_pattern_example.runners;

namespace design_pattern_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = StaticMethod.GetPropertyValueDic(typeof(PatternEnum));
            while (true)
            {
                Console.WriteLine("\nPlease select show patterns:");
                dic.Keys.ToList().ForEach(key =>
                {
                    Console.WriteLine($"value:{key}, pattern: {dic[key]}");
                });
                var patternStr = Console.ReadLine();
                var pattern = 0;
                Int32.TryParse(patternStr, out pattern);
                //var prototype = PatternFactory.CreateRunner((PatternEnum)pattern);
                var prototype = RunnerContext.GetRunner();
                Console.WriteLine("------------------------------------");
                prototype.Run();
                Console.WriteLine("------------------------------------");
            }
        }
    }

    public abstract class AsbstractPhone
    {
        public virtual void Call()
        {

        }
    }

    public class IPhone : AsbstractPhone
    {
        private int Field { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserNameWithID
        {
            get
            {
                return $"{UserName}({UserID})";
            }
        }

        private int TruePercent;
        public int Percent
        {
            get
            {
                return TruePercent * 100;
            }
            set
            {
                this.TruePercent = value / 100;
            }
        }
        public override void Call()
        {
            base.Call();
        }

        public string Call(string number)
        {

            return string.Empty;
        }

        public int Call(string number)
        {
            return 0;
        }

    }
}
