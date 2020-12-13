using System;
using System.Collections.Generic;

namespace SplitStrings
{
    public class Kata
    {
        public static string[] Solution(string str)
        {
            str = str.Length % 2 == 0 ? str : str += "_";

            string[] pairs = new string[str.Length/2];

            for (var i = 0; i < str.Length; i += 2)
            {
                pairs[i/2] = str.Substring(i,2);
            }

            return pairs;
        }
    }
}
