using FacadeSample1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacadeSample1Tests
{
    [TestClass]
    public class FacadeSample1Tests
    {
        [TestMethod]
        public void Toint()
        {
            //arrange
            var input = "123";
            var expected = 123;
            //act
            int actual;
            actual = MyTypeConverter.Toint(input);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToDecimal()
        {
            //arrange
            var input = "321";
            decimal expected = 321;
            //act
            decimal actual;
            actual = MyTypeConverter.ToDecimal(input);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}