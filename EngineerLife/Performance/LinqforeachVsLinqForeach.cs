using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerLife.Performance
{
    public class LinqforeachVsLinqForeach
    {
        public static void LamdaForeachByTimes(long times)
        {
            long sumTotal = 1;
            GetTimesNumbers(times).ForEach(x =>
            {
                sumTotal += x;
            });
        }

        public static void foreachByTimes(long times)
        {
            var sumTotal = 1;
            foreach (var x in GetTimesNumbers(times))
            {
                sumTotal += x;
            }
        }

        private static List<int> GetTimesNumbers(long times)
        {
            var numbers = new List<int>();
            for (int i = 0; i < times; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
