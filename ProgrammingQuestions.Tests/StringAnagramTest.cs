using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class StringAnagramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new StringAnagram();
            
            Assert.AreEqual(true, solution.IsAnagram("", ""));
            Assert.AreEqual(true, solution.IsAnagram("aaaa", "aaaa"));
            Assert.AreEqual(true, solution.IsAnagram("abcdef", "fedcba"));
            Assert.AreEqual(true, solution.IsAnagram("abcdef", "efabcd"));
            Assert.AreEqual(false, solution.IsAnagram("a", "b"));
            Assert.AreEqual(false, solution.IsAnagram("abcdef", "abcde"));
            Assert.AreEqual(false, solution.IsAnagram("aabcdef", "abcdeff"));
        }
    }
}
