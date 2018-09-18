using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class ArrayHillTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new ArrayHill();
            var array = new int[] { 5, 4, 3, 2, 8 };
            var result = solution.Calculate(array);
            Assert.AreEqual(3, result);
        }
    }
}
