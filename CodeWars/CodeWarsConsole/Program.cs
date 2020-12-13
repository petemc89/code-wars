using System;
using System.Linq;

namespace CodeWarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new char[] { 'a', 'b' };
            var arr2 = new char[] { 'b', 'a' };

            arr1 = arr1.OrderBy(i => i).ToArray();
            arr2 = arr2.OrderBy(i => i).ToArray();

            Console.WriteLine(arr1.SequenceEqual(arr2));
        }
    }
}
