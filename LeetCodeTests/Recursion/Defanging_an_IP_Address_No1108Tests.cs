using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Recursion;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Recursion.Tests
{
    [TestClass()]
    public class Defanging_an_IP_Address_No1108Tests
    {
        [TestMethod()]
        public void DefangIPaddrTest1()
        {
            //Arrange
            var swapNodesinPairs = new Defanging_an_IP_Address_No1108();
            var expected = "1[.]1[.]1[.]1";
            //Act
            var act = swapNodesinPairs.DefangIPaddr("1.1.1.1");
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void DefangIPaddrTest2()
        {
            //Arrange
            var swapNodesinPairs = new Defanging_an_IP_Address_No1108();
            var expected = "255[.]100[.]50[.]0";
            //Act
            var act = swapNodesinPairs.DefangIPaddr("255.100.50.0");
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}