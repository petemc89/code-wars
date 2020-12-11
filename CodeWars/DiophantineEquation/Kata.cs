using System;
using System.Collections.Generic;
using System.Linq;

namespace DiophantineEquation
{
    public class Kata
    {
        public static string solEquaStr(long n)
        {
            List<List<long>> solutions = FindSolutions(n);

            if (solutions.Count == 0)
                return "";

            List<string> stringifiedSolutions = StringifySolutions(solutions);

            return "[" + string.Join(", ", stringifiedSolutions) + "]";
        }

        private static List<List<long>> FindSolutions(long n)
        {
            long max = (n / 2) + 1;

            List<List<long>> solutions = new List<List<long>>();
            for (long x = 0; x <= max; x++)
            {
                for (long y = 0; y <= max; y++)
                {
                    if ((x - 2 * y) * (x + 2 * y) == n)
                    {
                        solutions.Add(new List<long>() { x, y });
                    }
                }
            }

            return solutions.OrderByDescending(solution => solution[0]).ToList();
        }

        private static List<string> StringifySolutions(List<List<long>> solutions)
        {
            List<string> stringifiedSolutions = new List<string>();
            foreach (List<long> solution in solutions)
            {
                string solutionString = "[" + string.Join(", ", solution) + "]";
                stringifiedSolutions.Add(solutionString);
            }

            return stringifiedSolutions;            
        }        
    }
}
