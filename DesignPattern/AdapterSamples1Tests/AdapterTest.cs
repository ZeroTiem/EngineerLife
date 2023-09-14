using AdapterSamples1;
using System.ComponentModel;

namespace AdapterSamples1Tests
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestNewAdapterA()
        {
            //arrange
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterA(adaptee);
            var expected = "This is 'Specific request.'";
            //act
            var actual = target.GetRequest();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNewAdapterB()
        {
            //arrange
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterB(adaptee);
            var expected = "This is not 'Specific request.'";
            //act
            var actual = target.GetRequest();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestNewAdapter()
        {
            //arrange
            Adaptee adaptee = new Adaptee();
            ITarget target = new AdapterB(adaptee);
            var expected = "This is not 'Specific request.'";
            //act
            var actual = target.GetRequest();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}