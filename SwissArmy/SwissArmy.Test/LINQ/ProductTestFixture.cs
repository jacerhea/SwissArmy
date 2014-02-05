using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.LINQ;

namespace SwissArmy.Test.LINQ
{
    [TestClass]
    public class ProductTestFixture
    {

        [TestMethod]
        public void TestZeroInputs()
        {
            var source = Enumerable.Empty<int>();
            var product = source.Product();
            Assert.AreEqual(1, product);
        }

        [TestMethod]
        public void TestOneInputs()
        {
            var source = new List<int> { 5 };
            var product = source.Product();
            Assert.AreEqual(5, product);
        }

        [TestMethod]
        public void TestFiveInputs()
        {
            var source = new List<int> { 5, 6, 7, 8, 9 };
            var product = source.Product();
            Assert.AreEqual(15120, product);
        }

        [TestMethod]
        public void TestOneNegativeInput()
        {
            var source = new List<int> { -5 };
            var product = source.Product();
            Assert.AreEqual(-5, product);
        }

        [TestMethod]
        //This assumes a non-checked overflow environment setting.
        public void TestNegativeInput()
        {
            var source = new List<int> { int.MaxValue, int.MaxValue };
            var product = source.Product();
            Assert.AreEqual(1, product);
        }
    }
}
