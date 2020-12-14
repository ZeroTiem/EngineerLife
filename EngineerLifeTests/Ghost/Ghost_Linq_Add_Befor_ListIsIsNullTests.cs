using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineerLife.Ghost;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerLife.Ghost.Tests
{
    [TestClass()]
    public class Ghost_Linq_Add_Befor_ListIsIsNullTests
    {
        [TestMethod()]
        public void AddListTest()
        {

            //Arrange
            var expected = new List<(int key, int index)>
            {
                (key: 1, index: 1),
                (key: 2, index: 1),
                (key: 3, index: 1),
                (key: 4, index: 1),
                (key: 5, index: 1),
                (key: 6, index: 1),
                (key: 7, index: 1),
                (key: 8, index: 1),
                (key: 9, index: 1)
            };
            var ghostLinqAddBeforListIsIsNull = new Ghost_Linq_Add_Befor_ListIsIsNull();
            //Act
            var act = ghostLinqAddBeforListIsIsNull.AddList();
            //Assert
            Assert.AreEqual(expected,act);
        }

        [TestMethod()]
        public void AddListMode1Test()
        {

            //Arrange
            var expected = new List<(int key, int index)>
            {
                (key: 1, index: 1),
                (key: 2, index: 1),
                (key: 3, index: 1),
                (key: 4, index: 1),
                (key: 5, index: 1),
                (key: 6, index: 1),
                (key: 7, index: 1),
                (key: 8, index: 1),
                (key: 9, index: 1)
            };
            var ghostLinqAddBeforListIsIsNull = new Ghost_Linq_Add_Befor_ListIsIsNull();
            //Act
            var act = ghostLinqAddBeforListIsIsNull.AddListMode1();
            //Assert
            Assert.AreEqual(expected, act);
        }
    }
}