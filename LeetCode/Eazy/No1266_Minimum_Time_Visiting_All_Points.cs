using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace LeetCode.Eazy
{
    //Runtime: 92 ms, faster than 98.05% of C# online submissions for Minimum Time Visiting All Points.
    //Memory Usage: 25.6 MB, less than 100.00% of C# online submissions for Minimum Time Visiting All Points.
    public class No1266_Minimum_Time_Visiting_All_Points
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var step = 0;
            var row = points.Length;

            for (int i = 0; i < row; i++)
            {
                var pointAx = points[i][0];
                var pointAy = points[i][1];

                if (i + 1 >= row)
                    break;

                var pointBx = points[i + 1][0];
                var pointBy = points[i + 1][1];

                var xStep = System.Math.Abs(pointAx - pointBx);
                var yStep = System.Math.Abs(pointAy - pointBy);

                if (xStep > yStep)
                    step += xStep;
                else
                    step += yStep;
            }

            return step;
        }
    }
}
