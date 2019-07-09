using InterviewFun;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewFunTests
{
    [TestClass]
    public class ChildToChildTests
    {
        private ChildToChild _childToChild;

        [TestMethod]
        public void ConvertTypeChildTest()
        {
            //Arrange
            _childToChild = new ChildToChild();
            var bus = new Bus { Length = 10, width = 10, Shape = "Rectangle", MaximumLoad = 100 };
            var expected = new SportsCar { Length = 10, width = 10, Shape = "Rectangle" };
            //Act
            var actual = _childToChild.ConvertTypeChild<Bus, SportsCar, Car>(bus);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
