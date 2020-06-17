using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineerLife.Performance;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineerLife.Performance.Tests
{
    [TestClass()]
    public class LinqforeachVsLinqForeachTests
    {
        [TestMethod()]
        public void LamdaForeachByTimesTest()
        {

            LinqforeachVsLinqForeach.LamdaForeachByTimes(2000000000);
        }

        [TestMethod()]
        public void foreachByTimesTest()
        {

            LinqforeachVsLinqForeach.foreachByTimes(2000000000);
        }
    }
}