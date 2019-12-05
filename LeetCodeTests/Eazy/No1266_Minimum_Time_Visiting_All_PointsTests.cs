using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Eazy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy.Tests
{
    [TestClass()]
    public class No1266_Minimum_Time_Visiting_All_PointsTests
    {
        [TestMethod()]
        public void BalancedStringSplitTest()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1266_Minimum_Time_Visiting_All_Points();
            var expected = 5;
            //Act
            var act = no1221SplitAStringInBalancedStrings.MinTimeToVisitAllPoints(new int[][]
            {
                new int[] { 3,2 },
                new int[] { -2,2 },
            });
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void BalancedStringSplitTest1()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1266_Minimum_Time_Visiting_All_Points();
            var expected = 7;
            //Act
            var act = no1221SplitAStringInBalancedStrings.MinTimeToVisitAllPoints(new int[][]
            {
                new int[] { 1,1 },
                new int[] { 3,4 },
                new int[] { -1,0 },
            });
            //Assert
            Assert.AreEqual(expected, act);
        }

    }
}