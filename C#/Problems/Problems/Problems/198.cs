using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _198 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 1 };

            var expected = 4;

            var result = Rob(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Rob(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
                return nums[0];
            var dp = new int[n];
            dp[0] = nums[0];
            dp[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; ++i)
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);
            return dp[n - 1];
        }
    }
}
