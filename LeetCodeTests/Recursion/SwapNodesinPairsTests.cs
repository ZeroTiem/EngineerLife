using System;
using System.Collections.Generic;
using System.Text;
using LeetCode;
using LeetCode.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class SwapNodesinPairsTests
    {
        [TestMethod]
        public void SwapPairsTest()
        {
            //Arrange
            var swapNodesinPairs = new SwapNodesinPairs();
            var actInput = new ListNode(1) { next = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) } } };
            var expected = new ListNode(2) { next = new ListNode(1) { next = new ListNode(4) { next = new ListNode(3) } } };
            //Act
            var act = swapNodesinPairs.SwapPairs(actInput);
            //Assert
            Assert.AreEqual(expected,act);
        }
    }
}
