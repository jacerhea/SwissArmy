using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.LINQ;

namespace SwissArmy.Test.LINQ
{
    [TestClass]
    public class MeanTestFixture
    {
        [TestMethod]
        public void EmptySetReturnsDefault()
        {
            var source = new List<int>();
            var result = source.Mean();
            Assert.AreEqual(default(int), result);
        }

        [TestMethod]
        public void SingleSetReturnsDefault()
        {
            var source = new List<int>{5};
            var result = source.Mean();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MultipleSetReturnsDefault()
        {
            var source = new List<int> { -10, 9, 8, 7, 6, 5, -4, 3, 2, -1 };
            var result = source.Mean();
            Assert.AreEqual(2.5, result);
        }
    }
}
