using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3654 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 1 };
            var k = 2;

            var expected = 1;

            var result = MinArraySum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinArraySum(int[] nums, int k)
        {
            var n = nums.Length;
            var dp = new long[k];
            for (int i = 0; i < k; ++i)
                dp[i] = long.MaxValue;
            long s = 0;
            dp[0] = 0;
            for (int i = 0; i < n; ++i)
            {
                s += nums[i];
                s = Math.Min(s, dp[s % k]);
                dp[s % k] = s;
            }

            return s;
        }   
    }
}
