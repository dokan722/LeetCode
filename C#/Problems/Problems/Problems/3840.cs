using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3840 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 4, 3, 5 };
            var colors = new[] { 1, 1, 2, 2 };

            var expected = 9;

            var result = Rob(nums, colors);

            Console.WriteLine(result);

            return expected == result;
        }

        public long Rob(int[] nums, int[] colors)
        {
            var n = nums.Length;
            long result = 0;
            var prev = -1;
            var dp = new long[2];
            long cur = 0;
            for (int i = 0; i < n; ++i)
            {
                if (prev != colors[i])
                {
                    result += cur;
                    dp[0] = 0;
                    dp[1] = 0;
                    prev = colors[i];
                }
                cur = Math.Max(nums[i] + dp[0], dp[1]);
                dp[0] = dp[1];
                dp[1] = cur;
            }
            result += cur;

            return result;
        }
    }
}
