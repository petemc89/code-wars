using System.Collections.Generic;
using System.Linq;

namespace YourOrderPlease
{
    public static class Kata
    {
        public static string Order(string words)
        {
            IEnumerable<string> wordList = words.Split(' ');

            IOrderedEnumerable<string> orderedList = wordList.OrderBy(word => word.FirstOrDefault(chr => char.IsDigit(chr)));

            return string.Join(' ', orderedList);
        }
    }
}
