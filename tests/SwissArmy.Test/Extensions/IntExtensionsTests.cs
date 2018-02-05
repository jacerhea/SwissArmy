using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.Extensions;

namespace SwissArmy.Test.Extensions
{
    [TestClass]
    public class IntExtensionsTests
    {
        [TestMethod]
        public void AreEven()
        {
            var testData = new List<int> {int.MinValue, 2, 0, 2, int.MaxValue - 1};
            var areEven = testData.All(i => i.IsEven());
            Assert.IsTrue(areEven);
        }

        [TestMethod]
        public void AreOdd()
        {
            var testData = new List<int> { int.MinValue + 1, 1, -1, int.MaxValue };
            var areOdd = testData.All(i => i.IsOdd());
            Assert.IsTrue(areOdd);
        }


        [TestMethod]
        public void NotOdd()
        {
            var testData = new List<int> { int.MinValue, 2, 0, 2, int.MaxValue - 1 };
            var notOdd = testData.All(i => !i.IsOdd());
            Assert.IsTrue(notOdd);
        }

        [TestMethod]
        public void NotEven()
        {
            var testData = new List<int> { int.MinValue + 1, 1, -1, int.MaxValue };
            var notEven = testData.All(i => !i.IsEven());
            Assert.IsTrue(notEven);
        }
    }
}
