using System;
using LeetCode.Eazy;
using LeetCode.Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class No1_Two_SumTests
    {
        private INo1_Two_Sum No1_Two_Sum;

        [TestMethod]
        public void TwoSumTest1()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum();
            
            var nums = new int[] { 2, 7, 11, 15 };
            Int32 target = 9;
            var expected = new int[] { 0,1 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums,target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest2()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum();

            var nums = new int[] { 3, 2, 4 };
            Int32 target = 6;
            var expected = new int[] { 1, 2 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest3()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum();

            var nums = new int[] { 3, 3 };
            Int32 target = 6;
            var expected = new int[] { 0, 1 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest1_1()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum1();

            var nums = new int[] { 2, 7, 11, 15 };
            Int32 target = 9;
            var expected = new int[] { 0, 1 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest2_1()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum1();

            var nums = new int[] { 3, 2, 4 };
            Int32 target = 6;
            var expected = new int[] { 1, 2 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest3_1()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum1();

            var nums = new int[] { 3, 3 };
            Int32 target = 6;
            var expected = new int[] { 0, 1 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void TwoSumTest2_3()
        {
            //Arrange
            No1_Two_Sum = new No1_Two_Sum3();

            var nums = new int[] { 3, 2, 4 };
            Int32 target = 6;
            var expected = new int[] { 1, 2 };

            //Act
            var act = No1_Two_Sum.TwoSum(nums, target);
            //Assert
            act.Should().BeEquivalentTo(expected);
        }
    }
}