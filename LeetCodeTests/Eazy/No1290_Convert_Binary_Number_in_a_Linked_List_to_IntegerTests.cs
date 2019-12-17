using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Eazy;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Eazy.Tests
{
    [TestClass()]
    public class No1290_Convert_Binary_Number_in_a_Linked_List_to_IntegerTests
    {
        [TestMethod()]
        public void GetDecimalValueTest()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer = new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode1 = new ListNode(1);
            var listNode2 = new ListNode(0);
            var listNode3 = new ListNode(1);
            listNode1.next = listNode2;
            listNode2.next = listNode3;
            var expected = 5;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode1);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}