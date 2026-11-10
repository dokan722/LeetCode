using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3693 : IProblem
    {
        public bool Test()
        {
            int n = 4;
            int[] costs = new int[] { 1, 2, 3, 4 };

            var expeceted = 13;

            var result = ClimbStairs(n, costs);

            Console.WriteLine(result);

            return result == expeceted;
        }

        public int ClimbStairs(int n, int[] costs)
        {
            var k = costs.Length;
            var dp = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
            dp[0] = 0;
            for (int i = 0; i < k; ++i)
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i] + costs[i] + 1);
                if (i < k - 1)
                    dp[i + 2] = Math.Min(dp[i + 2], dp[i] + costs[i + 1] + 4);
                if (i < k - 2)
                    dp[i + 3] = Math.Min(dp[i + 3], dp[i] + costs[i + 2] + 9);
            }


            return dp[n];
        }
    }
}
