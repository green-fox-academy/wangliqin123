using System.Collections.Generic;
using CountLetters;
using NUnit.Framework;

namespace CountLettersTest
{
    [TestFixture]
    public class CountTest
    {
        Count countClass = new Count();

        [Test]
        public void DictionaryMakerTest()
        {
            string word = "lotto";
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'l', 1},
                { 'o', 2},
                { 't', 2}
            };

            Assert.AreEqual(output, countClass.DictionaryMaker(word));
        }

        [Test]
        public void DictionaryMakerTestSingle()
        {
            string word = "lot";
            Dictionary<char, int> output = new Dictionary<char, int>()
            {
                { 'l', 1},
                { 'o', 1},
                { 't', 1}
            };

            Assert.AreEqual(output, countClass.DictionaryMaker(word));
        }
    }
}