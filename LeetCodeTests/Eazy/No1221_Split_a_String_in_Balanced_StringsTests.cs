using LeetCode.Eazy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class No1221_Split_a_String_in_Balanced_StringsTests
    {
        [TestMethod]
        public void BalancedStringSplitTest()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1221_Split_a_String_in_Balanced_Strings();
            var expected = 4;
            //Act
            var act = no1221SplitAStringInBalancedStrings.BalancedStringSplit("RLRRLLRLRL");
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void BalancedStringSplitTest1()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1221_Split_a_String_in_Balanced_Strings();
            var expected = 3;
            //Act
            var act = no1221SplitAStringInBalancedStrings.BalancedStringSplit("RLLLLRRRLR");
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void BalancedStringSplitTest2()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1221_Split_a_String_in_Balanced_Strings();
            var expected = 1;
            //Act
            var act = no1221SplitAStringInBalancedStrings.BalancedStringSplit("LLLLRRRR");
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void BalancedStringSplitTest3()
        {
            //Arrange
            var no1221SplitAStringInBalancedStrings = new No1221_Split_a_String_in_Balanced_Strings();
            var expected = 2;
            //Act
            var act = no1221SplitAStringInBalancedStrings.BalancedStringSplit("RLRRRLLRLL");
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}