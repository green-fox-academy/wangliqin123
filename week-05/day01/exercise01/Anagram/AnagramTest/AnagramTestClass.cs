using NUnit.Framework;
using System;
using Anagram;

namespace AnagramTest
{
    [TestFixture]

    class AnagramTestClass
    {
        AnagramClass anagramClass = new AnagramClass();

        static void Main(string[] args)
        {
        }

        [Test]
        public void TestAnagram_WhenInputAlmaAmla_ThenTrue()
        {
            string input1 = "alma";
            string input2 = "amla";
            bool output = true;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenInputAlmaKorte_ThenFalse()
        {
            string input1 = "alma";
            string input2 = "korte";
            bool output = false;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenInputEmpty_ThenFalse()
        {
            string input1 = String.Empty;
            string input2 = String.Empty;
            bool output = false;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenInputAlmaAaml_ThenTrue()
        {
            string input1 = "alma";
            string input2 = "aaml";
            bool output = true;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }
        [Test]
        public void TestAnagram_WhenInputalmaAlma_ThenTrue()
        {
            string input1 = "alma";
            string input2 = "Alma";
            bool output = true;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenInputAlmaAaaa_ThenFalse()
        {
            string input1 = "alma";
            string input2 = "aaaa";
            bool output = false;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }

        [Test]
        public void TestAnagram_WhenInputAlmaAl_ma_ThenTrue()
        {
            string input1 = "alma";
            string input2 = "al ma";
            bool output = true;

            Assert.AreEqual(output, anagramClass.IsAnagram(input1, input2));
        }
    }
}