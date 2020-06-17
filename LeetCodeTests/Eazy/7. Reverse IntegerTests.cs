using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        public void Input123Oupt321()
        {
            //Arrange
            var reverseInteger = new ReverseInteger();
            var expected = 321;
            var intput = 123;
            //Act
            var act = reverseInteger.Reverse(intput);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void InputNegative123OuptNegative321()
        {
            //Arrange
            var reverseInteger = new ReverseInteger();
            var expected = -321;
            var intput = -123;
            //Act
            var act = reverseInteger.Reverse(intput);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void Input120Oupt21()
        {
            //Arrange
            var reverseInteger = new ReverseInteger();
            var expected = -321;
            var intput = -123;
            //Act
            var act = reverseInteger.Reverse(intput);
            //Assert
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void Input1534236469()
        {
            //Arrange
            var reverseInteger = new ReverseInteger();
            var expected = 0;
            var intput = 1534236469;
            //Act
            var act = reverseInteger.Reverse(intput);
            //Assert
            Assert.AreEqual(expected, act);
        }


        
    }

}
