using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCode.StringKata.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void TestEmptyStringShouldEqualsToZero()
        {
            Assert.AreEqual(0, StringCalculator.Calculate(""));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, StringCalculator.Calculate("1"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(2, StringCalculator.Calculate("2"));
        }
    }
}
