using System;
using System.Linq;

namespace AreTheyTheSame
{
    public class Kata
    {
        public static bool Comp(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;

            int[] aSquared = a.Select(i => i * i).ToArray();
            Array.Sort(aSquared);
            Array.Sort(b);

            return aSquared.SequenceEqual(b);
        }
    }
}
