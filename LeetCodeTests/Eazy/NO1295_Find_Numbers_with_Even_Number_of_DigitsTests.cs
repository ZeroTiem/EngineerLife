using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeTests.Eazy;
using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Utilities;

namespace LeetCodeTests.Eazy.Tests
{
    [TestClass()]
    public class NO1295_Find_Numbers_with_Even_Number_of_DigitsTests
    {
        [TestMethod()]
        public void FindNumbersTest()
        {
            //Arrange
            var no1295_Find_Numbers_with_Even_Number_of_Digits = new NO1295_Find_Numbers_with_Even_Number_of_Digits();
            var nums = new int[] { 12, 345, 2, 6, 7896 };
            var expected = 2;
            //Act
            var act = no1295_Find_Numbers_with_Even_Number_of_Digits.FindNumbers(nums);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void FindNumbersTest1()
        {
            //Arrange
            var no1295_Find_Numbers_with_Even_Number_of_Digits = new NO1295_Find_Numbers_with_Even_Number_of_Digits();
            var nums = new int[] { 555, 901, 482, 1771 };
            var expected = 1;
            //Act
            var act = no1295_Find_Numbers_with_Even_Number_of_Digits.FindNumbers(nums);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}