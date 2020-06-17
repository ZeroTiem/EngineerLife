using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LeetCode.Eazy
{
    //Runtime: 68 ms, faster than 95.47% of C# online submissions for Split a String in Balanced Strings.
    //Memory Usage: 21.3 MB, less than 100.00% of C# online submissions for Split a String in Balanced
    public class No1221_Split_a_String_in_Balanced_Strings
    {
        public int BalancedStringSplit(string s)
        {
            var sCharArray = s.ToCharArray();

            var result = 0;

            var lCount = 0;
            var rCount = 0;

            foreach (var sChar in sCharArray)
            {
                if (sChar == 'L')
                    lCount++;

                if (sChar == 'R')
                    rCount++;

                if (lCount != rCount) continue;
                result++;
                lCount = 0;
                rCount = 0;
            }
            return result;
        }
    }
}
