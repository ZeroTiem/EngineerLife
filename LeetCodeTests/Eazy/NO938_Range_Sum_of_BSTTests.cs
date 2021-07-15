using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Eazy;
using LeetCode.Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class NO938_Range_Sum_of_BSTTests
    {
        [TestMethod]
        public void DefangIPaddrTest1()
        {
            //Arrange
            var no938RangeSumOfBst = new No938_Range_Sum_of_BST();
            var expected = 32;
            var root = new TreeNode(10)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(7),
                },
                right = new TreeNode(15)
                {
                    right = new TreeNode(18)
                }
            };
            //Act
            var act = no938RangeSumOfBst.RangeSumBST(root, 7, 15);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void DefangIPaddrTest2()
        {
            //Arrange
            var no938RangeSumOfBst = new No938_Range_Sum_of_BST();
            var expected = 23;
            var root = new TreeNode(10)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(1)
                    },
                    right = new TreeNode(7)
                    {
                        left = new TreeNode(6)
                    }
                },
                right = new TreeNode(15)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(18)
                }
            };
            //Act
            var act = no938RangeSumOfBst.RangeSumBST(root, 6, 10);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}
