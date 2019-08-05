using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            Helper(0, s);
        }

        public void Helper(int index, char[] str)
        {
            Stack<char> stack = new Stack<char>(str);
            var strLengthIndex = str.Length - 1;
            if (index > strLengthIndex)
            {
                str = stack.ToArray();
                return;
            }
            //if (1 >= str.Length || index > strLengthIndex / 2) return;
            //var swapTemp = str[index];
            //str[index] = str[strLengthIndex - index];
            //str[strLengthIndex - index] = swapTemp;
            stack.Push(str[strLengthIndex - index]);
            Helper(index + 1, str);
        }

        //public void Helper(int index, char[] str)
        //{
        //    var strLengthIndex = str.Length - 1;
        //    if (1 >= str.Length || index > strLengthIndex / 2) return;
        //    var swapTemp = str[index];
        //    str[index] = str[strLengthIndex - index];
        //    str[strLengthIndex - index] = swapTemp;
        //    Helper(index + 1, str);
        //}


    }
}
