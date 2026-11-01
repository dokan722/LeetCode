using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _673 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5, 4, 7 };

            var expected = 2;

            var result = FindNumberOfLIS(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindNumberOfLIS(int[] nums)
        {
            var n = nums.Length;
            var mx = 1;
            var dp = new (int L, int N)[n];
            dp[0] = (1, 1);
            for (int i = 1; i < n; ++i)
            {
                dp[i] = (1, 1);
                for (int j = 0; j < i; ++j)
                {
                    if (nums[i] > nums[j])
                    {
                        if (dp[j].L == dp[i].L - 1)
                            dp[i] = (dp[i].L, dp[i].N + dp[j].N);
                        else if (dp[j].L >= dp[i].L)
                            dp[i] = (dp[j].L + 1, dp[j].N);
                    }
                }
                mx = Math.Max(mx, dp[i].L);
            }
            var result = 0;
            for (int i = 0; i < n; ++i)
                if (dp[i].L == mx)
                    result += dp[i].N;
            return result;
        }
    }
}
