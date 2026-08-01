using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _486 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 2 };

            var expected = false;

            var result = PredictTheWinner(nums);

            return result == expected;
        }

        public bool PredictTheWinner(int[] nums)
        {
            var n = nums.Length;
            var first = n % 2;
            var dp = new int[n];
            for (int i = 0; i < n; ++i)
                dp[i] = first == 0 ? -nums[i] : nums[i];
            for (int i = n - 1; i > 0; --i)
            {
                var sh = n - i;
                for (int j = 0; j < i; ++j)
                {
                    dp[j] = i % 2 == 1 ? Math.Max(dp[j] + nums[j + sh], dp[j + 1] + nums[j]) : Math.Min(dp[j] - nums[j + sh], dp[j + 1] - nums[j]);
                }
            }

            return dp[0] >= 0;
        }
    }
}
