using LeetCode.Eazy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class No709_To_Lower_CaseTests
    {
        [TestMethod]
        public void ToLowerCaseTestInputHelloExpectedhello()
        {
            //Arrange
            var swapNodesinPairs = new No709_To_Lower_Case();
            var expected = "hello";
            //Act
            var act = swapNodesinPairs.ToLowerCase("Hello");
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void ToLowerCaseTestInputhelloExpectedhello()
        {
            //Arrange
            var swapNodesinPairs = new No709_To_Lower_Case();
            var expected = "hello";
            //Act
            var act = swapNodesinPairs.ToLowerCase("hello");
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}