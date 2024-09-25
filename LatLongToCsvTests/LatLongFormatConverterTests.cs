using Microsoft.VisualStudio.TestTools.UnitTesting;
using PdfToXlsx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfToXlsx.Tests
{
    [TestClass()]
    public class LatLongFormatConverterTests
    {
        [TestMethod()]
        public void SeperateConsecutiveNumbersTest()
        {
            string s = "242351.46";
            string expected = "24 23 51.46";

            Assert.AreEqual(expected, LatLongFormatConverter.SeperateConsecutiveNumbers(s));
        }
    }
}