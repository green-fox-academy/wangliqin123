using NUnit.Framework;
using System.Collections.Generic;
using OddAvg;

namespace OddAvgTest
{
    [TestFixture]
    public class OddAvgTestClass
    {
        OddAvgClass oddAvg = new OddAvgClass();

        [Test]
        public void OddAverageTest()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            double output = 2;

            Assert.AreEqual(output, oddAvg.OddAverage(numbers));
        }

        [Test]
        public void OddAverageTestWithEmptyList()
        {
            List<int> emptyList = new List<int>();
            double output = 0;

            Assert.AreEqual(output, oddAvg.OddAverage(emptyList));
        }

        [Test]
        public void OddAverageTestWithNullList()
        {
            double output = 1;

            Assert.AreEqual(output, oddAvg.OddAverage(null));
        }
    }
}