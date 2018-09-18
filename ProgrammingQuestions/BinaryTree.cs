using System;
using System.Collections.Generic;

namespace ProgrammingQuestions
{
    public class BinaryTree<T>
    {
        public T Value { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }

        public BinaryTree(T value)
        {
            this.Value = value;
        }

        public void Preorder(BinaryTree<T> bt, List<T> list)
        {
            if (bt == null)
            {
                list.Add(default(T));
                return;
            }

            if (object.Equals(bt.Value, default(T)))
            {
                throw new ArgumentException("default(T)");
            }

            list.Add(bt.Value);
            Preorder(bt.Left, list);
            Preorder(bt.Right, list);
        }

        public void Inorder(BinaryTree<T> bt, List<T> list)
        {
            if (bt == null)
            {
                list.Add(default(T));
                return;
            }

            if (object.Equals(bt.Value, default(T)))
            {
                throw new ArgumentException("default(T)");
            }

            Inorder(bt.Left, list);
            list.Add(bt.Value);
            Inorder(bt.Right, list);
        }

        public void Postorder(BinaryTree<T> bt, List<T> list)
        {
            if (bt == null)
            {
                list.Add(default(T));
                return;
            }

            if (object.Equals(bt.Value, default(T)))
            {
                throw new ArgumentException("default(T)");
            }

            Postorder(bt.Left, list);
            Postorder(bt.Right, list);
            list.Add(bt.Value);
        }

        public void FindPath(BinaryTree<T> bt, T value, ref bool found, Stack<BinaryTree<T>> stack)
        {
            if (found || bt == null)
            {
                return;
            }

            stack.Push(bt);
            if (object.Equals(bt.Value, value))
            {
                found = true;
                return;
            }

            FindPath(bt.Left, value, ref found, stack);
            FindPath(bt.Right, value, ref found, stack);

            if (!found)
            {
                stack.Pop();
            }
        }
    }
}
