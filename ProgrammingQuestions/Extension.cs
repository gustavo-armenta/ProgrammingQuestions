using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingQuestions
{
    public static class Extension
    {
        public static string ToText(this List<char> list)
        {
            var sb = new StringBuilder();
            foreach(var c in list)
            {
                if (c == '\0')
                {
                    sb.Append(",");
                }
                else
                {
                    sb.Append(c + ",");
                }
            }

            return sb.ToString();
        }

        public static string ToText(this List<int> list)
        {
            var sb = new StringBuilder();
            foreach (var c in list)
            {
                sb.Append(c + ",");                
            }

            return sb.ToString();
        }
    }
}
