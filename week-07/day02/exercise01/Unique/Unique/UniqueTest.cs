using NUnit.Framework;

namespace Unique
{
    [TestFixture]
    class UniqueTest
    {
        [Test]
        public void UniqueCharactersTest()
        {
            string inputWord = "catt";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestWithUpperCharacter()
        {
            string inputWord = "Catt";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }

        [Test]
        public void UniqueCharactersTestWhenInsideSpace()
        {
            string inputWord = "ca tt";
            char[] output = { 'c', 'a', 't' };

            Assert.AreEqual(output, Unique.UniqueCharacters(inputWord));
        }
    }
}