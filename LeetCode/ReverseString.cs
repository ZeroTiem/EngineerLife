using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
        private static int? _strLengthIndex;

        public void ReverseString(char[] s)
        {
            Helper(0, s);
        }

        public void Helper(int index, char[] str)
        {
            if(_strLengthIndex == null) _strLengthIndex = str.Length - 1;
            if (1 >= str.Length || index > _strLengthIndex / 2) return;
            var swapTemp = str[index];
            str[index] = str[_strLengthIndex.Value - index];
            str[_strLengthIndex.Value - index] = swapTemp;
            Helper(index + 1, str);
        }


    }
}
