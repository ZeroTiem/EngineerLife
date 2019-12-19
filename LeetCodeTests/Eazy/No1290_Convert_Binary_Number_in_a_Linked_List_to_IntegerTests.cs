using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Eazy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Utilities;
using LeetCode.Extension;

namespace LeetCode.Eazy.Tests
{
    [TestClass()]
    public class No1290_Convert_Binary_Number_in_a_Linked_List_to_IntegerTests
    {
        [TestMethod()]
        public void GetDecimalValueTest1()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer = new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new int[] { 1, 0, 1 }
                    ));

            var expected = 5;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void GetDecimalValueTest2()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer = new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new int[] { 0 }
                    ));
            var expected = 0;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void GetDecimalValueTest3()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer = new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new int[] { 1 }
                    ));
            var expected = 1;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod()]
        public void GetDecimalValueTest4()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer = new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new int[] { 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0 }
                    ));
            var expected = 18880;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

    }
}