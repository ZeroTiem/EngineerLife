using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 7. Reverse Integer https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            var index = 0 > x
                ? 1
                : 0;

            if (Int32.TryParse(new string(x.ToString()
                        .Substring(index)
                        .Reverse()
                        .ToArray()),
                    out int resultValue) ==
                false)
            {
                return 0;
            }

            //var resultValue = Convert.ToInt32();
            return index == 0
                ? resultValue
                : resultValue * -1;
        }
    }
}