using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProgrammingQuestions
{
    /*
You are given a string of length n which contains only letters from the English alphabet (a-z,A-Z). Compress it by replacing consecutive repeated characters by one instance of the character and an integer denoting the number of repetitions. If there is no repetition of the character, leave it as it is.
For example the string "aaaaabbbbbbbbbccccdeeeeeee" should be reduced to "a5b9c4de7".
As you may observe, the letter 'd' is not repeated, so no number is displayed after it.
  
Input Format 
There will be one line of input.
String of length n
Output Format
Print the compressed string.
Constraints
n <1024
Sample Input
aaaaabbbbbbbbbccccpqrstuv
Sample Output
a5b9c4pqrstuv
Explanation
There are 5 consecutive occurrences of 'a', followed by 9 occurrences of 'b', etc.
p, q, r through v are not followed by repeated characters, so no number needs to be printed after then in the output.  
     */
    public class StringCompression
    {        
    }
}
