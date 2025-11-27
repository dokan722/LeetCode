using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3381 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { -5, 1, 2, -3, 4 };
            var k = 2;

            var expected = 4;

            var result = MaxSubarraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxSubarraySum(int[] nums, int k)
        {
            var n = nums.Length;
            var worstPrefs = Enumerable.Repeat(long.MaxValue / 2, k).ToArray();
            long prefSum = 0;
            long maxSum = long.MinValue;
            worstPrefs[k - 1] = 0;
            for (int i = 0; i < n; ++i)
            {
                prefSum += nums[i];
                maxSum = Math.Max(maxSum, prefSum - worstPrefs[i % k]);
                worstPrefs[i % k] = Math.Min(worstPrefs[i % k], prefSum);
            }

            return maxSum;
        }
    }
}
