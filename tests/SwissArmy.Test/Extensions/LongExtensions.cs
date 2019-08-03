using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.Extensions;

namespace SwissArmy.Test.Extensions
{
    [TestClass]
    public class LongExtensionsTests
    {
        [TestMethod]
        public void AreEven()
        {
            var testData = new List<long> { long.MinValue, 2L, 0L, 2L, long.MaxValue - 1L };
            var areEven = testData.All(i => i.IsEven());
            Assert.IsTrue(areEven);
        }

        [TestMethod]
        public void AreOdd()
        {
            var testData = new List<long> { long.MinValue + 1L, 1L, -1L, long.MaxValue };
            var areOdd = testData.All(i => i.IsOdd());
            Assert.IsTrue(areOdd);
        }


        [TestMethod]
        public void NotOdd()
        {
            var testData = new List<long> { long.MinValue, 2L, 0L, 2L, long.MaxValue - 1 };
            var notOdd = testData.All(i => !i.IsOdd());
            Assert.IsTrue(notOdd);
        }

        [TestMethod]
        public void NotEven()
        {
            var testData = new List<long> { long.MinValue + 1L, 1L, -1L, long.MaxValue };
            var notEven = testData.All(i => !i.IsEven());
            Assert.IsTrue(notEven);
        }
    }
}
