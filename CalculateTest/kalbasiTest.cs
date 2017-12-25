using CalculateApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTest
{
    [TestClass]
   public class kalbasiTest
    {
        //[TestMethod]
        //public void AddWithEmptryString()
        //{
        //    kalbasi kalbasiAdd = new kalbasi();
        //    var result= kalbasiAdd.Add("");

        //    Assert.AreEqual(result, 0);

        //}


        [TestMethod]
        public void AddWithOneNumberInString()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("1");

            Assert.AreEqual(result, 1);

        }

        [TestMethod]
        public void AddWithTwoNumberInString()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("1,2");
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AddWithMoreThanTwoNumbersInString()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("1,2,123,1000");
            Assert.AreEqual(result, 1126);
        }


        [TestMethod]
        public void AddWithNewLine()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("1\n2,1000");
            Assert.AreEqual(result, 1003);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddWithNewLineWithErorr()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("1,\n");
        }

        [TestMethod]
        public void AddWithDelimiters()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("//;\n1;2");
            Assert.AreEqual(result, 3);
        }


        [TestMethod]
        [ExpectedException(typeof(FormatException),"negative not allowed")]
        public void AddWithNegativeNumbers()
        {
            kalbasi kalbasiAdd = new kalbasi();
            var result = kalbasiAdd.Add("-1,2,-3");
            
        }

        [TestMethod]
        
        public void Sin()
        {
            CalculateService calc = new CalculateService();
            var res = calc.Sin(30);
            Assert.AreEqual(res, "0.5");

            
        }
    }
}
