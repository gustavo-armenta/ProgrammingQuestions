using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    // Given a BinaryTree<char>, serialize and deserialize it.
    // Assume '\0' is an empty node
    public class BinaryTreeSerialization
    {
        public void Serialize(BinaryTree<char> bt, List<char> list)
        {
            if (bt == null)
            {
                list.Add('\0');
                return;
            }

            list.Add(bt.Value);
            Serialize(bt.Left, list);
            Serialize(bt.Right, list);
        }

        public BinaryTree<char> Deserialize(List<char> list, ref int index)
        {
            if (index > list.Count - 1)
            {
                return null;
            }

            char value = list[index];
            if (value == '\0')
            {
                return null;
            }

            var bt = new BinaryTree<char>(value);
            index++;
            bt.Left = Deserialize(list, ref index);
            index++;
            bt.Right = Deserialize(list, ref index);

            return bt;
        }
    }
}
