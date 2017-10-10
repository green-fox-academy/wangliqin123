using NUnit.Framework;

namespace Unique
{
    [TestFixture]
    class UniqueTest
    {
        [Test]
        public void UniqueCharactersTest()
        {
            string inputWord = "cat";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestIsUpper()
        {
            string inputWord = "Cat";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestWhenInsideSpace()
        {
            string inputWord = "ca t";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }
    }
}