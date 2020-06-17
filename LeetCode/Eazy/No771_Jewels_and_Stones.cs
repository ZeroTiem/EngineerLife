using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Eazy
{
    //Runtime: 76 ms, faster than 71.14% of C# online submissions for Jewels and Stones.
    //Memory Usage: 23 MB, less than 7.14% of C# online submissions for Jewels and Stones.
    //todo IsBad

    public class No771_Jewels_and_Stones
    {
        public int NumJewelsInStones(string J, string S)
        {
            var jArray = J.ToCharArray();
            var sArray = S.ToCharArray();
            return sArray.Count(x=> jArray.Contains(x));
        }
    }
}
