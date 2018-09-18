using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class ArrayInterleaveTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new ArrayInterleave();
            var array1 = new int[] { 1, 3, 5, 7, 9 };
            var array2 = new int[] { 2, 4, 6, 8, 10 };
            solution.Interleave(array1, array2);
            var expectedArray1 = new int[] { 1, 2, 3, 4, 5 };
            var expectedArray2 = new int[] { 6, 7, 8, 9, 10 };
            for (int i = 0; i < array1.Length; i++)
            {
                Assert.AreEqual(expectedArray1[i], array1[i]);
                Assert.AreEqual(expectedArray2[i], array2[i]);
            }
        }
    }
}
