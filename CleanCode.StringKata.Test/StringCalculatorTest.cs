using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCode.StringKata.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator _calculator;

        [TestInitialize]
        public void SetUp()
        {
            _calculator = new StringCalculator();
        }

        [TestMethod]
        public void TestEmptyStringShouldEqualsToZero()
        {
            Assert.AreEqual(0, _calculator.Add(""));
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, _calculator.Add("1"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(2, _calculator.Add("2"));
        }

        [TestMethod]
        public void Test1comma2()
        {
            Assert.AreEqual(3, _calculator.Add("1,2"));
        }

        [TestMethod]
        public void TestUnknownAmountOfNumbers()
        {
            Assert.AreEqual(21, _calculator.Add("1,2,3,4,5,6"));
        }

        [TestMethod]
        public void TestNewLineIsAllowedSeparator()
        {
            Assert.AreEqual(6, _calculator.Add("1\n2,3"));
        }

        [TestMethod]
        public void TestSeparatorCanBeConfigured()
        {
            Assert.AreEqual(3, _calculator.Add("//;\n1;2"));
        }
    }
}
