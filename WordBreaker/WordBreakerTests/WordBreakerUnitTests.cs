using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordBreaker;

namespace WordBreakerTests
{
    [TestClass]
    public class WordBreakerUnitTests
    {
        private TheWordBreaker WordBreaker;
        private List<string> EmptyList;
        private List<string> ListWithOneWord;
        private List<string> ListWithTwoWords;

        [TestInitialize]
        public void TestInitialize()
        {
            WordBreaker = new TheWordBreaker();
            EmptyList = new List<string>();
            ListWithOneWord = new List<string>() { "test" };
            ListWithTwoWords = new List<string>() { "test", "string" };
        }

        [TestMethod]
        public void TheWordBreakerShouldReturnFalseWhenWordListIsEmpty()
        {
            TestInitialize();
            Assert.AreEqual(false, WordBreaker.DoesStringContainAnyProvidedWords("TestString", EmptyList));
        }

        [TestMethod]
        public void TheWordBreakerShouldReturnFalseWhenStringDoesNotContainAnyWordsFromWordList()
        {
            TestInitialize();
            Assert.AreEqual(false, WordBreaker.DoesStringContainAnyProvidedWords("AString", ListWithOneWord));
        }

        [TestMethod]
        public void TheWordBreakerShouldReturnTrueWhenStringContainsOneWordFromWordList()
        {
            TestInitialize();
            Assert.AreEqual(true, WordBreaker.DoesStringContainAnyProvidedWords("TestString", ListWithOneWord));
        }

        [TestMethod]
        public void TheWordBreakerShouldReturnTrueWhenStringContainsTwoWordsFromWordList()
        {
            TestInitialize();
            Assert.AreEqual(true, WordBreaker.DoesStringContainAnyProvidedWords("TestString", ListWithTwoWords));
        }
    }
}