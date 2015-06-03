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
            Assert.AreEqual(0, StringCalculator.Add(""));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, StringCalculator.Add("1"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(2, StringCalculator.Add("2"));
        }

        [TestMethod]
        public void Test1comma2()
        {
            Assert.AreEqual(3, StringCalculator.Add("1,2"));
        }

        [TestMethod]
        public void TestUnknownAmountOfNumbers()
        {
            Assert.AreEqual(21, StringCalculator.Add("1,2,3,4,5,6"));
        }

        [TestMethod]
        public void TestNewLineIsAllowedSeparator()
        {
            Assert.AreEqual(6, StringCalculator.Add("1\n2,3"));
        }
    }
}
