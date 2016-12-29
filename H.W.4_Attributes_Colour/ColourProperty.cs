using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H.W._4_Attributes_Colour
{
    class ColourProperty
    {
        public static void ColorPrint(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo p in properties)
            {
                if (p.IsDefined(typeof(СolourAttribute), false))
                {
                    СolourAttribute items = (СolourAttribute)p.GetCustomAttribute(typeof(СolourAttribute), false);
                    Console.ForegroundColor = items.Colour;
                    Console.WriteLine(p.GetValue(obj));
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(p.GetValue(obj));
                }
            }
        }

    }
}
