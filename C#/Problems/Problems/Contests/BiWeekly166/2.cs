using Problems.Problems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly166
{
    public class _2 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var costs = new[] { 9, 8, 3 };

            var expected = 12;

            var result = ClimbStairs(n, costs);

            Console.WriteLine(result);

            return expected == result;
        }

        public int ClimbStairs(int n, int[] costs)
        {
            var k = costs.Length;
            var dp = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
            dp[0] = 0;
            for (int i = 0; i < k; ++i)
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i] + costs[i] + 1);
                if (i <  k - 1)
                    dp[i + 2] = Math.Min(dp[i + 2], dp[i] + costs[i + 1] + 4);
                if (i < k - 2)
                    dp[i + 3] = Math.Min(dp[i + 3], dp[i] + costs[i + 2] + 9);
            }


            return dp[n];
        }
    }
}
