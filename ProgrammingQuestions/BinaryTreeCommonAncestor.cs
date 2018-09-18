using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    /*
     * Given two nodes of a tree,
     * method should return the deepest common ancestor of those nodes.
     *
     *          A                           A
     *         / \                         / \
     *        B   C                       B   C
     *       / \                         /     \
     *      D   E                       D       E
     *         / \                     /         \
     *        F   G                   F           G
     *
     *  commonAncestor(D, F) = B
     *  commonAncestor(C, G) = A
     *  commonAncestor(E, B) = B
     */

    public static class BinaryTreeCommonAncestor
    {
        public static char CommonAncestor(this BinaryTree<char> bt, char v1, char v2)
        {
            var stack1 = new Stack<BinaryTree<char>>();
            var stack2 = new Stack<BinaryTree<char>>();
            var found1 = false;
            var found2 = false;
            bt.FindPath(bt, v1, ref found1, stack1);
            bt.FindPath(bt, v2, ref found2, stack2);

            // make both stacks of same size
            while (stack1.Count > stack2.Count)
            {
                stack1.Pop();
            }

            while (stack2.Count > stack1.Count)
            {
                stack2.Pop();
            }

            // find common node
            while(stack1.Count > 0)
            {
                var p1 = stack1.Pop();
                var p2 = stack2.Pop();

                if(p1.Value == p2.Value)
                {
                    return p1.Value;
                }
            }

            return '\0';
        }
    }
}
