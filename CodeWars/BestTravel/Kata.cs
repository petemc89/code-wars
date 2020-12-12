using System;
using System.Collections.Generic;
using System.Linq;

namespace BestTravel
{
    public static class Kata
    {
        public static int? ChooseBestSum(int t, int k, List<int> ls)
        {
            var combinations = ls.Combinations(k);

            int? result = 0;

            foreach (var combination in combinations)
            {
                int sum = combination.Sum();

                if (sum <= t && sum > result)
                {
                    result = sum;
                }
            }

            return result == 0 ? null : result;
        }

        private static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
