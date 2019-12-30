using LeetCode.Eazy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class No1266_Minimum_Time_Visiting_All_PointsTests
    {
        [TestMethod]
        public void BalancedStringSplitTest()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1266_Minimum_Time_Visiting_All_Points();
            var expected = 5;
            //Act
            var act = no1221SplitAStringInBalancedStrings.MinTimeToVisitAllPoints(new[]
            {
                new[] {3, 2},
                new[] {-2, 2}
            });
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void BalancedStringSplitTest1()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1266_Minimum_Time_Visiting_All_Points();
            var expected = 7;
            //Act
            var act = no1221SplitAStringInBalancedStrings.MinTimeToVisitAllPoints(new[]
            {
                new[] {1, 1},
                new[] {3, 4},
                new[] {-1, 0}
            });
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}