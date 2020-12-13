using System;
using System.Linq;

namespace EqualSidesOfAnArray
{
    public class Kata
    {
        public static int FindEvenIndex(int[] arr)
        {
            // Create an array of incremental sums
            int[] incrementalArr = new int[arr.Length];
            int sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                incrementalArr[i] = sum;
            }

            // Reverse the array and loop through
            int[] reversedArr = arr.Reverse().ToArray();
            int reverseSum = 0;
            for (var i = 0; i < reversedArr.Length; i++)
            {                
                // Increment a sum
                reverseSum += reversedArr[i];

                // Compare the sum with the reverse index (aka original index) of the incremented array(length - this.index)
                int originalIndex = incrementalArr.Length - i - 1;
                if (reverseSum == incrementalArr[originalIndex])
                {
                    // Return the original index
                    return originalIndex;
                }
            }

            // Or return -1 if no matches found
            return -1;
        }
    }
}
