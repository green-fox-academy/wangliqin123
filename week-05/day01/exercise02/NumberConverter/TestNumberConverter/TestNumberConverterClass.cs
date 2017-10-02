using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberConverter;

namespace TestNumberConverter
{
    [TestFixture]
    public class TestNumberConverterClass
    {
        NumberConverterClass numberConverterClass = new NumberConverterClass();

        [Test]
        public void NumbConvertToWords_When745ThanString745()
        {
            int input = 745;
            string output = "seven hundred and fourty five";

            Assert.AreEqual(output, numberConverterClass.NumbConvertToWords(input));
        }

        [Test]
        public void NumbConvertToWords_WhenThanString745()
        {
            int input = 640;
            string output = "six hundred and fourty";

            Assert.AreEqual(output, numberConverterClass.NumbConvertToWords(input));
        }
    }
}
