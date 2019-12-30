using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy
{
    public class NO1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer
    {
        public int SubtractProductAndSum(int n)
        {
            //Design 1 70%
            var reuslt = OperationSum(n, 1, 0);
            return reuslt.multiplicationSum - reuslt.plusSum;

            //Design 2 
            //var reuslt = OperationSum(n, 1, 0);
            //return reuslt.multiplicationSum - reuslt.plusSum;
        }

        //Design 1 
        //Runtime: 36 ms, faster than 94.34% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
        //Memory Usage: 14.6 MB, less than 100.00% of C# online submissions for Subtract the Product and Sum of Digits of an Integer.
        private (int multiplicationSum, int plusSum) OperationSum(int number, int multiplicationSum = 1, int plusSum = 0)
        {
            var lastNumber = number % 10;
            plusSum += lastNumber;
            multiplicationSum *= lastNumber;
            number /= 10;
            if (number > 0)
            {
                return OperationSum(number, multiplicationSum, plusSum);
            }
            return (multiplicationSum, plusSum);
        }

        //Design 2
        //private (int multiplicationSum, int plusSum) OperationSum(int number)
        //{

        //}

        //private List<int> IntToListInt(int number)
        //{
        //    var ints = new List<int>();
        //    var lastNumber = number % 10;
        //    ints.Add(lastNumber);
        //    number /= 10;
        //    if (number > 0)
        //    {
        //        return IntToListInt(number);
        //    }
        //    return ints;
        //}

    }
}
