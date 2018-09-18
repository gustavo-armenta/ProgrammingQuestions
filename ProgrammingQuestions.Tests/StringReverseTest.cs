using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class StringReverseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new StringReverse();

            Assert.AreEqual("Panama! canal, a plan, a man, A", solution.ReverseWords("A man, a plan, a canal, Panama!"));
            Assert.AreEqual("Roma Amor,", solution.ReverseWords("Amor, Roma"));
            Assert.AreEqual("car race", solution.ReverseWords("race car"));
            Assert.AreEqual("cat taco", solution.ReverseWords("taco cat"));
            Assert.AreEqual("saw? I cat a or car a it Was", solution.ReverseWords("Was it a car or a cat I saw?"));
            Assert.AreEqual("Nixon in 'x' No", solution.ReverseWords("No 'x' in Nixon"));
        }
    }
}
