using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace design_pattern_example.common
{
    public static class StaticMethod
    {
        public static string GetMemory(object obj)
        {
            GCHandle h = GCHandle.Alloc(obj, GCHandleType.WeakTrackResurrection);

            IntPtr addr = GCHandle.ToIntPtr(h);

            return $"0x{addr.ToString("x")}";
        }

        public static Dictionary<int, string> GetPropertyValueDic(Type type)
        {
            var fields = type.GetFields().Where(info => info.FieldType == type).Select(info => info.Name).ToList();
            var dictionary = new Dictionary<int, string>();
            for (int i = 0; i < fields.Count(); i++)
            {
                dictionary.Add(i, fields[i]);
            }
            return dictionary;
        }

        public static string GetInput(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
