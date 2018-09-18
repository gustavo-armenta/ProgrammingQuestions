using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class StringPalindromeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new StringPalindrome();
            
            Assert.AreEqual(true, solution.IsPalindrome("A man, a plan, a canal, Panama!"));
            Assert.AreEqual(true, solution.IsPalindrome("Amor, Roma"));
            Assert.AreEqual(true, solution.IsPalindrome("race car"));
            Assert.AreEqual(true, solution.IsPalindrome("taco cat"));
            Assert.AreEqual(true, solution.IsPalindrome("Was it a car or a cat I saw?"));
            Assert.AreEqual(true, solution.IsPalindrome("No 'x' in Nixon"));
            Assert.AreEqual(false, solution.IsPalindrome("Not a palindrome"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var solution = new StringPalindrome();
            
            Assert.AreEqual(true, solution.IsPalindromeAnyPermutation("mmo"));
            Assert.AreEqual(true, solution.IsPalindromeAnyPermutation("yakak"));
            Assert.AreEqual(false, solution.IsPalindromeAnyPermutation("travel"));
        }
    }
}
