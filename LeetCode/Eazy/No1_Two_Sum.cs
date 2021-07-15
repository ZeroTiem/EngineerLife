using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy
{
    public interface INo1_Two_Sum
    {
        int[] TwoSum(int[] nums, int target);
    }

    //
    //Round 1
    //Runtime: 328 ms, faster than 42.10% of C# online submissions for Two Sum.
    //Memory Usage: 32.6 MB, less than 52.03% of C# online submissions for Two Sum.
    //Round 2
    //Runtime: 320 ms, faster than 51.13% of C# online submissions for Two Sum.
    //Memory Usage: 32.2 MB, less than 87.91% of C# online submissions for Two Sum.
    public class No1_Two_Sum : INo1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = (i + 1); j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            return new[] {0, 0};
        }
    }


    public class No1_Two_Sum1 : INo1_Two_Sum
    {
        private static int _target;
        private static int[] _nums;
        private static int _length;

        public int[] TwoSum(int[] nums, int target)
        {
            _length = nums.Length;
            _nums = nums;
            _target = target;
            return sumInts();
        }

        int[] sumInts(int index = 0, int indey = 0)
        {
            indey++;

            //比對位置 X 超過長度
            if (index > _length - 1)
            {
                return default;
            }

            //比對位置 Y 超過長度 或是 Y 超過剩餘數
            if (indey > _length - 1)
            {
                index++; //X+1
                indey = index + 1; //重製Y並且往X之後一格開始
            }

            //正確答案 回傳元素位置
            if (_nums[index] + _nums[indey] == _target)
            {
                return new[] {index, indey};
            }

            //繼續往下走
            return sumInts(index, indey);
        }


    }

    //Round 1
    //Runtime: 244 ms, faster than 83.75% of C# online submissions for Two Sum.
    //Memory Usage: 32.6 MB, less than 39.53% of C# online submissions for Two Sum.
    //Round 2
    //Runtime: 244 ms, faster than 83.75% of C# online submissions for Two Sum.
    //Memory Usage: 32.6 MB, less than 39.53% of C# online submissions for Two Sum.
    public class No1_Two_Sum2 : INo1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new int[] {i, dict[diff]};
                else
                    dict.Add(nums[i], i);
            }

            return new int[] {0, 0};
        }
    }

   
    public class No1_Two_Sum3 : INo1_Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var table = new Hashtable();
            table[nums[0]] = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (table.Contains(diff))
                {
                    return new int[2] { (int)table[diff], i };
                }

                var origin = target - diff;
                if (!table.Contains(origin))
                {
                    table[origin] = i;
                }
            }
            return new int[] { 0, 0 };
        }
    }


}
