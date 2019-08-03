using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.LINQ;

namespace SwissArmy.Test.LINQ
{
    [TestClass]
    public  class WrapTestFixture
    {
        [TestMethod]
        public void TestZeroInputs()
        {
            var source = Enumerable.Empty<int>();
            var count = source.Wrap(item => item == 3).Count();
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void TestSkipping5()
        {
            var source = Enumerable.Range(-1, 10);
            var set = source.Wrap(item => item == 4).ToList();
            var count = set.Count();
            Assert.AreEqual(count, 10);
            Assert.AreEqual(4, set.First());
        }

        [TestMethod]
        public void TestSkippingAll()
        {
            var source = Enumerable.Range(1, 10);
            var set = source.Wrap(item => item == 11).ToList();
            var count = set.Count();
            Assert.AreEqual(count, 10);
        }

        [TestMethod]
        public void TestSkippingNone()
        {
            var source = Enumerable.Range(1, 10);
            var set = source.Wrap(item => item == 1).ToList();
            var count = set.Count();
            Assert.AreEqual(count, 10);
        }
    }
}
