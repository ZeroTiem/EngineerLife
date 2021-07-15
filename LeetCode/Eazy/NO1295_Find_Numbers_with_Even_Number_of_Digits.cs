using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTests.Eazy
{
    public class No1295_Find_Numbers_with_Even_Number_of_Digits
    {
        public int FindNumbers(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                if (numberLengthIsEvenNumber(num))
                    result++;
            }
            return result;
        }

        private bool numberLengthIsEvenNumber(int number)
        {
            return number.ToString().Length % 2 == 0;
        }

    }
}
