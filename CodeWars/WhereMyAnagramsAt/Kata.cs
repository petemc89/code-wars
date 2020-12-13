using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereMyAnagramsAt
{
    public class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            char[] orderedWordChars = word.OrderBy(i => i).ToArray();

            List<string> anagramsFound = new List<string>();
            foreach (var target in words)
            {
                char[] orderedTargetChars = target.OrderBy(i => i).ToArray();

                if (orderedTargetChars.SequenceEqual(orderedWordChars))
                {
                    anagramsFound.Add(target);
                }
            }

            return anagramsFound;
        }
    }
}
