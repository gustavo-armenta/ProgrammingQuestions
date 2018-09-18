using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class BinaryTreeSerializationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new BinaryTreeSerialization();
            var bt = new BinaryTree<char>('A');
            bt.Left = new BinaryTree<char>('B');
            bt.Right = new BinaryTree<char>('C');
            bt.Left.Left = new BinaryTree<char>('D');
            bt.Left.Right = new BinaryTree<char>('E');
            bt.Left.Right.Left = new BinaryTree<char>('F');
            bt.Left.Right.Right = new BinaryTree<char>('G');

            int index = 0;
            var serialized = new List<char>();
            solution.Serialize(bt, serialized);
            var bt2 = solution.Deserialize(serialized, ref index);

            var preorderList = new List<char>();
            bt2.Preorder(bt2, preorderList);
            string expected = "A,B,D,,,E,F,,,G,,,C,,,";
            Assert.AreEqual(expected, preorderList.ToText());
        }
    }
}
