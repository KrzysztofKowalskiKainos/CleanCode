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

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(System.ArgumentException), "Negatives not allowed: -1")]
        public void TestNegativeWillThrowException()
        {
            _calculator.Add("1,2,3,-1,4,5");
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(System.ArgumentException), "Negatives not allowed: -2, -1, -5")]
        public void TestManyNegativesWillThrowException()
        {
            _calculator.Add("1,-2,3,-1,4,-5");
        }

        [TestMethod]
        public void TestIgnoringBiggerThan1000()
        {
            Assert.AreEqual(0, _calculator.Add("1001"));
        }

        [TestMethod]
        public void TestIgnoringManyBiggerThan1000()
        {
            Assert.AreEqual(10, _calculator.Add("//x\n1x2x1001x3x1337x4"));
        }

        [TestMethod]
        public void TestAnyLengthDelimiters()
        {
            Assert.AreEqual(6, _calculator.Add("//[***]\n1***2***3"));
        }
    }

    // @see http://stackoverflow.com/a/9152420/17405
    public sealed class ExpectedExceptionWithMessage : ExpectedExceptionBaseAttribute
    {
        private Type _expectedExceptionType;
        private string _expectedExceptionMessage;

        public ExpectedExceptionWithMessage(Type expectedExceptionType)
        {
            _expectedExceptionType = expectedExceptionType;
            _expectedExceptionMessage = string.Empty;
        }

        public ExpectedExceptionWithMessage(Type expectedExceptionType, string expectedExceptionMessage)
        {
            _expectedExceptionType = expectedExceptionType;
            _expectedExceptionMessage = expectedExceptionMessage;
        }

        protected override void Verify(Exception exception)
        {
            Assert.IsNotNull(exception);

            Assert.IsInstanceOfType(exception, _expectedExceptionType, "Wrong type of exception was thrown.");

            if(!_expectedExceptionMessage.Length.Equals(0))
            {
                Assert.AreEqual(_expectedExceptionMessage, exception.Message, "Wrong exception message was returned.");
            }
        }
    }
}
