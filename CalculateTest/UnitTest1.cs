using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateTest
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void ReturnZeroWhenNull()
        {
            CalculateApp.CalculateService calc = new CalculateApp.CalculateService();
            string input = "1+4*5";
            string aa = calc.Calculate(input);
            Assert.AreEqual(aa ,"0");
        }

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

    }
}
