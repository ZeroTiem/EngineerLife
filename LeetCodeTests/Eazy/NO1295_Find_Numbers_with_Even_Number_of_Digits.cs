using System;
using System.Linq;

namespace LeetCodeTests.Eazy
{
    public class NO1295_Find_Numbers_with_Even_Number_of_Digits
    {
        public int FindNumbers(int[] nums)
        {
            return nums.Count(NumberLengthIsEvenNumber);
        }

        private bool NumberLengthIsEvenNumber(int number)
        {
            //73.84%
            //return number.ToString().Length % 2 == 0;

            //88.11% 
            //return GetNumberLength(number) % 2 == 0;

            //97.90% 
            return GetNumberLength1(number) % 2 == 0;
        }

        private int GetNumberLength(int number)
        {
            return (int) Math.Floor(Math.Log10(number)) + 1;
        }

        private int GetNumberLength1(int number)
        {
            var length = 1;
            while (number >= 10)
            {
                number /= 10;
                length++;
            }

            return length;
        }
    }
}