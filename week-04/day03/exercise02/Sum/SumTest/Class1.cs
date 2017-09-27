using NUnit.Framework;
using System.Collections.Generic;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SumTest
    {
        [Test]
        public void SumElementsTest()
        {
            List<int> numbs = new List<int> { 2, 3, 4 };
            SumNumb SumClass= new SumNumb();
            int output = 9;

            Assert.AreEqual(output, SumClass.SumElements(numbs));
        }

        [Test]
        public void SumElementsTestEmpty()
        {
            List<int> emptyList = new List<int>();
            SumNumb SumClass = new SumNumb();
            int output = 0;

            Assert.AreEqual(output, SumClass.SumElements(emptyList));
        }

        [Test]
        public void SumElementsTestOne()
        {
            List<int> oneList = new List<int> { 2 };
            SumNumb SumClass = new SumNumb();
            int output = 2;

            Assert.AreEqual(output, SumClass.SumElements(oneList));
        }

        [Test]
        public void SumElementsTestNull()
        {
            SumNumb SumClass = new SumNumb();
            int output = 10;

            Assert.AreEqual(output, SumClass.SumElements(null));
        }
    }
}