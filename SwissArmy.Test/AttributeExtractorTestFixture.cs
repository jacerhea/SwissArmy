using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissArmy.Attributes;

namespace SwissArmy.Test
{
    [TestClass]
    public class AttributeExtractorTestFixture
    {
        [TestMethod]
        public void TestPropertyAttributeExtractor()
        {
            var test = new TestClass();
            var displayAttribute = test.GetAttributeFrom<DisplayAttribute, TestClass>(o => o.AProperty);
            Assert.AreEqual(displayAttribute.Name, "TestName");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethodAttributeExtractor()
        {
            var test = new TestClass();
            var displayAttribute = test.GetAttributeFrom<DisplayAttribute, TestClass>(o => o.Hello());
        }

        public class TestClass
        {
            [Display(Name = "TestName")]
            public string AProperty { get; set; }

            [Display(Name = "Hello method")]
            public string Hello()
            {
                return string.Empty;
            }
        }
    }
}
