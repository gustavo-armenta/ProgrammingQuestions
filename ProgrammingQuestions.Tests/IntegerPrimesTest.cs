using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class IntegerPrimesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new IntegerPrimes();

            Assert.AreEqual("2,", solution.FindPrimes(2).ToText());
            Assert.AreEqual("2,3,5,7,", solution.FindPrimes(9).ToText());
            Assert.AreEqual("2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97,", solution.FindPrimes(99).ToText());
        }
    }
}
