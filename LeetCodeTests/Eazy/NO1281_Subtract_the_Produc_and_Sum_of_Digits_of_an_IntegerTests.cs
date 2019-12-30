using LeetCode.Eazy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Eazy
{
    [TestClass]
    public class NO1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_IntegerTests
    {
        [TestMethod]
        public void SubtractProductAndSumTest_Input_234_Expected_15()
        {
            //Arrange
            var no1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer =
                new NO1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer();
            var expected = 15;
            //Act
            var act = no1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer.SubtractProductAndSum(234);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void SubtractProductAndSumTest_Input_4421_Expected_21()
        {
            //Arrange
            var no1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer =
                new NO1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer();
            var expected = 21;
            //Act
            var act = no1281_Subtract_the_Produc_and_Sum_of_Digits_of_an_Integer.SubtractProductAndSum(4421);
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}