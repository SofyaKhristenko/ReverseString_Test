using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace UnitTestAnagram
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void ToAnagram_alphabetLetters()
        {
            string inputText = "abcd efgh";
            Solution solutionAnagram = new Solution();
           
            string actualText = solutionAnagram.ToAnagram(inputText);

            string expectedText = "dcba hgfe";
            Assert.AreEqual(expectedText, actualText);
        }

        [TestMethod]
        public void ToAnagram_symbolText()
        {
            string inputText = "a1bcd efg!h";
            Solution solutionAnagram = new Solution();

            string actualText = solutionAnagram.ToAnagram(inputText);

            string expectedText = "d1cba hgf!e";
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
