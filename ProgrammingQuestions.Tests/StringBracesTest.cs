using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class StringBracesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new StringBraces();

            Assert.AreEqual(false, solution.Check(")(){}"));
            Assert.AreEqual(true, solution.Check("[]({})"));
            Assert.AreEqual(true, solution.Check("([])"));
            Assert.AreEqual(true, solution.Check("{()[]}"));
            Assert.AreEqual(false, solution.Check("([)]"));
        }
    }
}
