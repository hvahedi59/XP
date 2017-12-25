using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateApp;

namespace CalculateTest
{

    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //[ExpectedException(typeof(DivideByZeroException))]
        //public void WhenDividedByZeroThrowException()
        //{
        //    CalculateService calcService = new CalculateService();
        //    string result = calcService.Calculate("2/0");
        //}
        [TestMethod]
        public void WhenDividByZeroGetResult()
        {
            CalculateService calcService = new CalculateService();
            string result = calcService.Calculate("4/2");
        }

        //[TestMethod]
        //public void ReturnZeroWhenNull()
        //{
        //    CalculateApp.CalculateService calc = new CalculateApp.CalculateService();
        //    string input = "1+4*5";
        //    string aa = calc.Calculate(input);
        //    Assert.AreEqual(aa ,"0");
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ReturnExceptionWithCharecter()
        {
            CalculateApp.CalculateService calc = new CalculateApp.CalculateService();
            string input = "1+4*5a";
            string aa = calc.Calculate(input);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateMultiAsign()
        {
            CalculateApp.CalculateService calc = new CalculateApp.CalculateService();
            string input = "1****5*2";
            string aa = calc.Calculate(input);
            Assert.AreEqual(aa, "10");
        }

        [TestMethod]
        public void TestPower()
        {
            CalculateService calc = new CalculateService();

            var result = calc.Calculate2("2^3");

            Assert.AreEqual(result, "8");
        }

        [TestMethod]
        public void TestPower2()
        {
            CalculateService calc = new CalculateService();

            var result = calc.Calculate2("2^3+1");

            Assert.AreEqual(result, "16");
        }
    }
}
