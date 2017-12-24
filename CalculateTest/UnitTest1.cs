using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateApp;

namespace CalculateTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void WhenDividedByZeroThrowException()
        {
            CalculateService calcService = new CalculateService();
            string result = calcService.Calculate("2/0");
        }
        [TestMethod]
        public void WhenDividByZeroGetResult()
        {
            CalculateService calcService = new CalculateService();
            string result = calcService.Calculate("4/2");
        }
    }
}
