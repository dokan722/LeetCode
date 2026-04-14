using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _746 : IProblem
    {
        public bool Test()
        {
            var cost = new[] { 10, 15, 20 };

            var expected = 15;

            var result = MinCostClimbingStairs(cost);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinCostClimbingStairs(int[] cost)
        {
            var n = cost.Length;
            var dp = new int[n + 1];
            for (int i = 2; i <= n; ++i)
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);

            return dp[n];
        }
    }
}
