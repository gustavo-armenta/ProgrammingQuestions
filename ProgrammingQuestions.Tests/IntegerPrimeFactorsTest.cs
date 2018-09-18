using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class IntegerPrimeFactorsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new IntegerPrimeFactors();

            Assert.AreEqual("2,2,", solution.FindPrimeFactors(4).ToText());
            Assert.AreEqual("3,2,", solution.FindPrimeFactors(9).ToText());
            Assert.AreEqual("5,3,", solution.FindPrimeFactors(125).ToText());
            Assert.AreEqual("", solution.FindPrimeFactors(126).ToText());
        }
    }
}
