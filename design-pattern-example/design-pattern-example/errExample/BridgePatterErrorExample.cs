using design_pattern_example.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_example.errExample
{
    /// <summary>
    /// 业务要求，点奶茶，可以点大杯、小杯、中杯和冷的、热的、常温的
    /// </summary>
    public class BridgePatterErrorExample
    {
        /// <summary>
        /// 奶茶类
        /// </summary>
        public class MilkTea
        {
            public string SizeDescription { get; set; }
            public string TemperatureDescription { get; set; }

            public MilkTea(string size, string temp)
            {
                this.SizeDescription = size;
                this.TemperatureDescription = temp;
            }

            public void ShowMilkTeaInfo()
            {
                Console.WriteLine($"这是一份{SizeDescription}{TemperatureDescription}奶茶");
            }
        }

        #region 硬编码
        /// <summary>
        /// 最笨的实现方式，硬编码，不利于扩展
        /// </summary>
        public class MilkTeaShop
        {
            public MilkTea OrderMilkTea(SizeEnum size, TemperatureEnum temperature)
            {
                var sizeResult = "";
                var temperatureResult = "";
                switch (size)
                {
                    case SizeEnum.Small:
                        sizeResult = "小杯";
                        break;
                    case SizeEnum.Middle:
                        sizeResult = "中杯";
                        break;
                    case SizeEnum.Big:
                        sizeResult = "大杯";
                        break;
                    default:
                        break;
                }

                switch (temperature)
                {
                    case TemperatureEnum.Cold:
                        temperatureResult = "冷的";
                        break;
                    case TemperatureEnum.Normal:
                        temperatureResult = "常温";
                        break;
                    case TemperatureEnum.Hot:
                        temperatureResult = "热的";
                        break;
                    default:
                        break;
                }

                var tea = new MilkTea(sizeResult, temperatureResult);
                tea.ShowMilkTeaInfo();
                return tea;
            }
        }

        #endregion

        #region 提取抽象
        public interface IMilkTea
        {
            MilkTea OrderMilkTea(SizeEnum size);
        }
        /// <summary>
        /// 问题在于，像这种可以多维度扩展的类，只提取一个抽象是不够的
        /// 因此需要使用桥接模式来扩展多维度的功能
        /// </summary>
        public class ColdMilk : IMilkTea
        {
            public MilkTea OrderMilkTea(SizeEnum size)
            {
                var sizeResult = "";
                switch (size)
                {
                    case SizeEnum.Small:
                        sizeResult = "小杯";
                        break;
                    case SizeEnum.Middle:
                        sizeResult = "中杯";
                        break;
                    case SizeEnum.Big:
                        sizeResult = "大杯";
                        break;
                    default:
                        break;
                }
                return new MilkTea(sizeResult, "冷的");
            }
        }

        public class HotMilk : IMilkTea
        {
            public MilkTea OrderMilkTea(SizeEnum size)
            {
                var sizeResult = "";
                switch (size)
                {
                    case SizeEnum.Small:
                        sizeResult = "小杯";
                        break;
                    case SizeEnum.Middle:
                        sizeResult = "中杯";
                        break;
                    case SizeEnum.Big:
                        sizeResult = "大杯";
                        break;
                    default:
                        break;
                }
                return new MilkTea(sizeResult, "热的");
            }
        }
        #endregion


        #region 使用桥接模式，选择一个扩展维度为基础来进行抽象
        /// <summary>
        /// 这里选择了size作为基础维度，其他维度则通过桥接方式实现
        /// </summary>
        public abstract class AbstractSizeMilkTeaBuilder
        {
            protected ITemperatureBuilder temperature;
            public AbstractSizeMilkTeaBuilder(ITemperatureBuilder temp)
            {
                this.temperature = temp;
            }
            public abstract MilkTea OrderMilkTea();
        }

        /// <summary>
        /// 为了演示简单，桥接器在这基础上进行桥接
        /// </summary>
        public class SmallMilkTeaBuilder : AbstractSizeMilkTeaBuilder
        {
            public SmallMilkTeaBuilder(ITemperatureBuilder temp): base(temp) { }
            public override MilkTea OrderMilkTea()
            {

                return new MilkTea("小杯", base.temperature.getTemperature());
            }
        }

        public class BigMilkTeaBuilder : AbstractSizeMilkTeaBuilder
        {
            public BigMilkTeaBuilder(ITemperatureBuilder temp) : base(temp) { }
            public override MilkTea OrderMilkTea()
            {

                return new MilkTea("大杯", base.temperature.getTemperature());
            }
        }

        //桥接器
        public interface ITemperatureBuilder
        {
            string getTemperature();
        }

        public class ColdTemperatureBuilder : ITemperatureBuilder
        {
            public string getTemperature()
            {
                return "冷的";
            }
        }

        public class HotTemperatureBuilder : ITemperatureBuilder
        {
            public string getTemperature()
            {
                return "热的";
            }
        }
        #endregion

    }
}
