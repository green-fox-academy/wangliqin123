using NUnit.Framework;
using Apple;

namespace AppleTest
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void GetAppleTest()
        {
            string fruit = "apple";

            var apples = new Apples(fruit);

            string output = apples.GetApple();

            Assert.AreEqual(fruit, output);
        }

        [Test]
        public void GetAppleTestEmpty()
        {
            string fruit = "";

            var apples = new Apples(fruit);

            string output = apples.GetApple();

            Assert.AreEqual(fruit, output);
        }
    }
}