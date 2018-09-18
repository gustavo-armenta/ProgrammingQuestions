using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgrammingQuestions.Tests
{
    [TestClass]
    public class BinaryTreeCommonAncestorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bt = new BinaryTree<char>('A');
            bt.Left = new BinaryTree<char>('B');
            bt.Right = new BinaryTree<char>('C');
            bt.Left.Left = new BinaryTree<char>('D');
            bt.Left.Right = new BinaryTree<char>('E');
            bt.Left.Right.Left = new BinaryTree<char>('F');
            bt.Left.Right.Right = new BinaryTree<char>('G');

            Assert.AreEqual('B', bt.CommonAncestor('D', 'F'));
            Assert.AreEqual('A', bt.CommonAncestor('C', 'G'));
            Assert.AreEqual('B', bt.CommonAncestor('E', 'B'));
            Assert.AreEqual('E', bt.CommonAncestor('F', 'G'));
        }
    }
}
