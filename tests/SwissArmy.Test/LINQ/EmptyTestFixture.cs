using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.LINQ;

namespace SwissArmy.Test.LINQ
{
    [TestClass]
    public class EmptyTestFixture
    {
        [TestMethod]
        public void EmptySetReturnsTrue()
        {
            var source = new List<int>();
            var result = source.Empty();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NonEmptySetReturnsFalse()
        {
            var source = new List<int>{1};
            var result = source.Empty();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void EmptySet_From_Overload_ReturnsTrue()
        {
            var source = new List<int> {1, 2, 3, 4, 5};
            var result = source.Empty(i => i == 6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NonEmptySet_From_Overload_ReturnsFalse()
        {
            var source = new List<int> { 1, 2, 3, 4, 5 };
            var result = source.Empty(i => i == 6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrown()
        {
            List<int> source = null;
            var result = source.Empty();
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionThrown_From_Overload()
        {
            List<int> source = null;
            var result = source.Empty(i => i == 6);
            Assert.Fail();
        }
    }
}
