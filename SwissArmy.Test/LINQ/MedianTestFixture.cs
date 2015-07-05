using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.LINQ;

namespace SwissArmy.Test.LINQ
{
    [TestClass]
    public class MedianTestFixture
    {
        [TestMethod]
        public void EmptySetReturnsDefault()
        {
            var source = new List<int>();
            var result = source.Median();
            Assert.AreEqual(default(int), result);
        }

        [TestMethod]
        public void SingleSetReturnsDefault()
        {
            var source = new List<int> { 5 };
            var result = source.Median();
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MultipleEvenSetReturnsDefault()
        {
            var source = new List<int> { -10, 9, 8, 7, 6, 5, -4, 3, 2, -1 };
            var result = source.Median();
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void MultipleOddSetReturnsDefault()
        {
            var source = new List<int> { -10, 9, 8, 7, 6, 5, -4, 3, 2 };
            var result = source.Median();
            Assert.AreEqual(5, result);
        }
    }
}
