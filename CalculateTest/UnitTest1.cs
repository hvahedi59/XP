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
            string input = "";
            string aa = calc.Calculate(input);
            Assert.AreEqual(aa ,"0");
        }
    }
}
