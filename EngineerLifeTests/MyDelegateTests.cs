using System;
using System.Collections.Generic;
using System.Text;
using EngineerLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EngineerLifeTests
{
    [TestClass]
    public class MyDelegateTests
    {
        [TestMethod]
        public void DemoFuncHaveReturn()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoFuncHaveReturn();
            //Assert
            Assert.AreEqual(myDelegate.Result,3);
        }

        [TestMethod]
        public void DemoFuncHaveReturn_Resharper()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoFuncHaveReturn_Resharper();
            //Assert
            Assert.AreEqual(myDelegate.Result, 2);
        }

        [TestMethod]
        public void DemoFuncHaveReturn_Resharper1()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoFuncHaveReturn_Resharper1();
            //Assert
            Assert.AreEqual(myDelegate.Result, 2);
        }


        [TestMethod]
        public void DemoFuncNotReturn()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoFuncNotReturn();
            //Assert
            Assert.AreEqual(myDelegate.Result, 1);
        }

        [TestMethod]
        public void DemoActionNoParameters()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoActionNoParameters();
            //Assert
            Assert.AreEqual(myDelegate.Result, "DemoActionNoParameters");
        }

        [TestMethod]
        public void DemoActionNoParameters_Resharper()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoActionNoParameters_Resharper();
            //Assert
            Assert.AreEqual(myDelegate.Result, "DemoActionNoParameters_Resharper");
        }

        [TestMethod]
        public void DemoAction()
        {
            //Arrange
            var myDelegate = new MyDelegate();
            //Act
            myDelegate.DemoAction();
            //Assert
            Assert.AreEqual(myDelegate.Result, "DemoAction");
        }
    }
}
