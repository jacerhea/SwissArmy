using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissArmy.Test.LINQ
{
    /// <summary>
    /// Summary description for DistinctByTestFixture
    /// </summary>
    [TestClass]
    public class DistinctByTestFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testSet = new List<TestClass>
            {
                new TestClass {Field1 = 1, Field2 = "TestClass1Field1"},
                new TestClass {Field1 = 2, Field2 = "TestClass2Field1"},
                new TestClass {Field1 = 3, Field2 = "TestClass2Field1"},
                new TestClass {Field1 = 2, Field2 = "TestClass2Field"},
            };
        }


        private class TestClass
        {
            public int Field1 { get; set; }
            public string Field2 { get; set; }
        }
    }
}
