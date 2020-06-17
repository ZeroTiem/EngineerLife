using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium.Tests
{
    [TestClass()]
    public class No1282_Group_the_People_Given_the_Group_Size_They_Belong_ToTests
    {
        [TestMethod()]
        public void GroupThePeopleTest()
        {
            //Arrange
            var no1282GroupThePeopleGivenTheGroupSizeTheyBelongTo = new No1282_Group_the_People_Given_the_Group_Size_They_Belong_To();
            var expected = new List<List<int>>
            {
                new List<int> {0, 1, 2},
                new List<int> {3, 4, 6},
                new List<int> {5},
            };
            //Act
            var act = no1282GroupThePeopleGivenTheGroupSizeTheyBelongTo.GroupThePeople(new[] { 3, 3, 3, 3, 3, 1, 3 });
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}