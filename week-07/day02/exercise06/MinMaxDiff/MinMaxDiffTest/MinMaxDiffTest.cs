using NUnit.Framework;
using System.Collections.Generic;
using MinMaxDiff;

namespace MinMaxDiffTest
{
    [TestFixture]
    public class MinMaxDiffTest
    {
        MinMaxDiffClass minMax = new MinMaxDiffClass();

        [Test]
        public void TestMinMaxDiffTest()
        {
            List<int> numbers = new List<int> { 2, 12, 23 };
            int output = 21;

            Assert.AreEqual(output, minMax.MinMaxDiff(numbers));
        }

        [Test]
        public void TestMinMaxDiffWithEmptyList()
        {
            List<int> emptyNumbers = new List<int>();
            int output = 0;

            Assert.AreEqual(output, minMax.MinMaxDiff(emptyNumbers));
        }

        [Test]
        public void TestMinMaxDiffWithNull()
        {
            int output = 1;

            Assert.AreEqual(output, minMax.MinMaxDiff(null));
        }
    }
}