using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1218 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 5, 7, 8, 5, 3, 4, 2, 1 };
            var difference = -2;

            var expected = 4;

            var result = LongestSubsequence(arr, difference);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestSubsequence(int[] arr, int difference)
        {
            var subsequences = new Dictionary<int, int>();
            var maxLength = 0;
            foreach (var num in arr)
            {
                var prev = num - difference;
                if (subsequences.ContainsKey(prev))
                    subsequences[num] = subsequences[prev] + 1;
                else
                    subsequences[num] = 1;
                maxLength = Math.Max(maxLength, subsequences[num]);
            }

            return maxLength;
        }
    }
}
