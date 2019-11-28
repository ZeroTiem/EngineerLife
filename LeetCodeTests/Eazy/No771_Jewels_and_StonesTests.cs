using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Eazy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy.Tests
{
    [TestClass()]
    public class No771_Jewels_and_StonesTests
    {
        public No771_Jewels_and_Stones No771JewelsAndStones = new No771_Jewels_and_Stones();

        [TestMethod()]
        public void DefangIPaddrTest1()
        {
            //Arrange
            var j = "aA";
            var s = "aAAbbbb";
            var expected = 3;
            //Act
            var act = No771JewelsAndStones.NumJewelsInStones(j,s);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void DefangIPaddrTest2()
        {
            //Arrange
            var j = "z";
            var s = "ZZ";
            var expected = 0;
            //Act
            var act = No771JewelsAndStones.NumJewelsInStones(j, s);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}