using NUnit.Framework;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramClassTest
    {
        AnagramClass anaCLass = new AnagramClass();

        [Test]
        public void IsAnagramTest()
        {
            string first = "silver";
            string second = "livers";

            bool output = true;

            Assert.AreEqual(output, anaCLass.IsAnagram(first, second));
        }

        [Test]
        public void IsAnagramTestNotEqual()
        {
            string first = "silver";
            string second = "liver";

            bool output = false;

            Assert.AreEqual(output, anaCLass.IsAnagram(first, second));
        }

        [Test]
        public void IsAnagramTestNotSameLetters()
        {
            string first = "silver";
            string second = "qliver";

            bool output = false;

            Assert.AreEqual(output, anaCLass.IsAnagram(first, second));
        }
    }
}