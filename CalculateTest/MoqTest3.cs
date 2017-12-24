using CalculateApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace CalculateTest
{
    [TestClass]
   public class MoqTest3
    {
        [TestMethod]
        public void WhenConvertUSDoGBPUnitTimesRate()
        {
            //Arrange
            Calculator3 calc = new Calculator3();
            var mockFeed = new Mock<ICurencyConverter3>();
            mockFeed.Setup(x => x.GetGBPRate()).Returns(500);
          //  Act
            int result = calc.ConvertUSDtoGBP(mockFeed.Object,1);
          //  Assert
            Assert.AreEqual(500, result);

        }
    }
}
