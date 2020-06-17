using System.Collections.Generic;
using LeetCode.Eazy;
using LeetCode.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class No1290_Convert_Binary_Number_in_a_Linked_List_to_IntegerTests
    {
        [TestMethod]
        public void GetDecimalValueTest1()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer =
                new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new[] {1, 0, 1}
                    ));

            var expected = 5;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void GetDecimalValueTest2()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer =
                new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new[] {0}
                    ));
            var expected = 0;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void GetDecimalValueTest3()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer =
                new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new[] {1}
                    ));
            var expected = 1;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void GetDecimalValueTest4()
        {
            //Arrange
            var no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer =
                new No1290_Convert_Binary_Number_in_a_Linked_List_to_Integer();
            var listNode =
                Utility.GenerateListNode(
                    new Queue<int>(
                        new[] {1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0}
                    ));
            var expected = 18880;
            //Act
            var act = no1290_Convert_Binary_Number_in_a_Linked_List_to_Integer.GetDecimalValue(listNode);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}