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
    }
}
