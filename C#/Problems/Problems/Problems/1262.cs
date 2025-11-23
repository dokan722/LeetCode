using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1262 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 6, 5, 1, 8 };

            var expected = 18;

            var result = MaxSumDivThree(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSumDivThree(int[] nums)
        {
            var n = nums.Length;

            var dp = new[] { 0, int.MinValue, int.MinValue };

            for (int i = 0; i < n; i++)
            {
                var curr = new int[3];
                for (int j = 0; j < 3; ++j)
                    curr[j] = Math.Max(dp[j], dp[(j - (nums[i] % 3) + 3) % 3] + nums[i]);
                dp = curr;
            }

            return dp[0];
        }
    }
}
