using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CleanCode.StringKata.Test
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator calculator =new StringCalculator();
        [TestMethod]
        public void Test_Empty_Parameter()
        {

            Assert.AreEqual(0, calculator.Add(""));
        }
        [TestMethod]
        public void Test_one_Parameter()
        {
            Assert.AreEqual(1, calculator.Add("1"));
        }

        [TestMethod]
        public void Test_two_Parameters()
        {
            Assert.AreEqual(3, calculator.Add("1,2"));
        }

        [TestMethod]
        public void Test_many_Parameters()
        {
            Assert.AreEqual(6, calculator.Add("1,2\n3"));
        }


        [TestMethod]
        public void Test_many_Parameters_with_declared_separator()
        {
            Assert.AreEqual(6, calculator.Add("//;\n1;2;3"));
        }

        [TestMethod]
        [ExpectedException( typeof(Exception))]
        public void Test_negatives()
        {
            try
            {
                calculator.Add("//;\n1;-2;3");
            }catch(Exception ex)
            {
                Assert.AreEqual("negatives found : -2", ex.Message);
                throw;
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_multi_negatives()
        {
            try
            {
                calculator.Add("//;\n1;-2;-3");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("negatives found : -2,-3", ex.Message);
                throw;
            }

        }
        [TestMethod]
        public void Test_many_Parameters_with_declared_separator1()
        {
            Assert.AreEqual(6, calculator.Add("//[**]\n1**2**3"));
        }

        [TestMethod]
        public void Test_many_Parameters_with_declared_separator2()
        {
            Assert.AreEqual(6, calculator.Add("//[**][*]\n1**2*3"));
        }

        [TestMethod]
        public void Test_many_Parameters_with_declared_separator3()
        {
            Assert.AreEqual(6, calculator.Add("//[**][;]\n1**2;3"));
        }

    }
}
