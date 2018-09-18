using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingQuestions
{
    // A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. Allowances may be made for adjustments to capital letters, punctuation, and word dividers. 
    public class StringPalindrome
    {
        public bool IsPalindrome(string value)
        {
            string s = Regex.Replace(value, @"[^\w]", string.Empty).ToLower();

            for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, j--)
            {
                if(s[i] != s[j])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsPalindromeAnyPermutation(string value)
        {
            string s = Regex.Replace(value, @"[^\w]", string.Empty).ToLower();
            var contents = new Dictionary<char, int>();

            foreach(var c in s)
            {
                if(!contents.ContainsKey(c))
                {
                    contents[c] = 0;
                }

                contents[c] = (contents[c] + 1) % 2;
            }

            if(contents.Values.Sum() > 1)
            {
                return false;
            }

            return true;
        }
    }
}
