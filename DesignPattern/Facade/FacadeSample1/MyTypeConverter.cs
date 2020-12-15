using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeSample1
{
    public class MyTypeConverter
    {
        public static int Toint<T>(T input)
        {
            return Convert.ToInt32(input);
        }

        public static decimal ToDecimal<T>(T input)
        {
            return Convert.ToDecimal(input);
        }
    }
}
