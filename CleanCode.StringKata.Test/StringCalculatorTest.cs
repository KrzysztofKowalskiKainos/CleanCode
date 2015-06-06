using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCode.StringKata.Test
{
    [TestClass]
    public class StringCalculatorTest
    {

        private StringCalculator stringCalculator;

        [TestInitialize]
        public void Initialize()
        {
            this.stringCalculator = new StringCalculator();
        }

       

        [TestMethod]
        public void When_CalculateIsCalled_TestAddEmpty()
        {
            String input = "";
            int result=stringCalculator.Calculate(input);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddOneNumber()
        {

            String input = "3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddTwoNumbersComaSeparated()
        {

            String input = "2,3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddThreeNumbersComaSeparated()
        {

            String input = "2,3,4";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 9);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddTenNumbersComaSeparated()
        {

            String input = "1,2,1,1,1,1,0,1,1";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 9);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddThreeNumbersNewlineSeparated()
        {
            String input = "1\n2,3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddThreeNumbersSemicolonSeparated()
        {
            String input = "//;;\n1;;2;;3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestAddMoreThanThousand()
        {
            String input = "1,2,3,1001";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 6);
        }

      

        [TestMethod]
        public void When_CalculateIsCalled_TestSpecialDelimiter()
        {
            String input = "//[***]\n1***2***3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void When_CalculateIsCalled_TestMultipleDelimiters()
        {
            String input = "//[*][%]\n1*2%3";
            int result = stringCalculator.Calculate(input);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void When_CalculateIsCalled_WithNegative_TestThrowsException()
        {
            String input = "//[*][%]\n-1*-2%3";
           
            Exception expectedExcetpion = null;

            try
            {
                 stringCalculator.Calculate(input);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            Assert.IsNotNull(expectedExcetpion);
            StringAssert.Contains(expectedExcetpion.Message, "-1");
            StringAssert.Contains(expectedExcetpion.Message, "-2");
        }

    }
}
