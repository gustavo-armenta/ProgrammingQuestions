using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    // Strings are said to be anagrams if they have same characters but in different order. For example, abcd and dcba are anagrams.
    public class StringAnagram
    {
        public bool IsAnagram(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }

            var charMap = new Dictionary<char, int>();

            foreach(char c in s1)
            {
                if(!charMap.ContainsKey(c))
                {
                    charMap[c] = 0;
                }

                charMap[c] = charMap[c] + 1;
            }

            foreach (char c in s2)
            {
                if (!charMap.ContainsKey(c))
                {
                    return false;
                }

                charMap[c] = charMap[c] - 1;
                if(charMap[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
