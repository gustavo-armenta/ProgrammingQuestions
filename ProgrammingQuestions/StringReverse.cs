using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingQuestions
{
    public class StringReverse
    {
        public string ReverseWords(string value)
        {
            char[] s = value.ToCharArray();
            Reverse(s, 0, s.Length - 1);
            int beginIndex = 0;
            for (int endIndex = 0; endIndex <= s.Length; endIndex++)
            {
                if (endIndex == s.Length || s[endIndex] == ' ')
                {
                    Reverse(s, beginIndex, endIndex - 1);
                    beginIndex = endIndex + 1;
                }
            }

            return new string(s);
        }

        public void Reverse(char[] s, int beginIndex, int endIndex)
        {
            for (int i = beginIndex, j = endIndex; i < (beginIndex + endIndex + 1) / 2; i++, j--)
            {
                char c = s[i];
                s[i] = s[j];
                s[j] = c;
            }
        }
    }
}
