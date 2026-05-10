using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2770 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 6, 4, 1, 2 };
            var target = 2;

            var expected = 3;

            var result = MaximumJumps(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumJumps(int[] nums, int target)
        {
            var n = nums.Length;
            var dp = new int[n];
            for (int i = n - 2; i >= 0; --i)
            {
                var mx = -1;

                for (int j = i + 1; j < n; ++j)
                {
                    if (Math.Abs(nums[i] - nums[j]) <= target && dp[j] != -1)
                    {
                        mx = Math.Max(mx, dp[j] + 1);
                    }
                }
                dp[i] = mx;
            }

            return dp[0];
        }
    }
}
