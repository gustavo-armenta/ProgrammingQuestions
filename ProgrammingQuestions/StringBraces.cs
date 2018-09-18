using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    // Given a string containing three types of braces: round (), square [] and curly {}
    // Write a function to check whether the braces match
    public class StringBraces
    {
        private char[] openBraces = new char[] { '(', '[', '{' };
        private char[] closeBraces = new char[] { ')', ']', '}' };

        public bool Check(string s)
        {
            var stack = new Stack<int>();

            foreach (var c in s)
            {
                int openBraceIndex = IsOpenBrace(c);
                if (openBraceIndex > -1)
                {
                    stack.Push(openBraceIndex);
                    continue;
                }

                int closeBraceIndex = IsCloseBrace(c);
                if (closeBraceIndex > -1)
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    openBraceIndex = stack.Pop();
                    if(openBraceIndex != closeBraceIndex)
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private int IsOpenBrace(char c)
        {
            for (int i = 0; i < openBraces.Length; i++)
            {
                if (c == openBraces[i])
                {
                    return i;
                }
            }

            return -1;
        }

        private int IsCloseBrace(char c)
        {
            for (int i = 0; i < closeBraces.Length; i++)
            {
                if (c == closeBraces[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
