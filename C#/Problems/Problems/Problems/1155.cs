using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1155 : IProblem
    {
        public bool Test()
        {
            var n = 30;
            var k = 30;
            var target = 500;

            var expected = 222616187;

            var result = NumRollsToTarget(n, k, target);

            Console.WriteLine(result);

            return expected == result;
        }

        private int _mod = 1000000007;

        public int NumRollsToTarget(int n, int k, int target)
        {
            var dp = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                dp[i] = Enumerable.Repeat(-1, target + 1).ToArray();
            return NumRollsRec(n, k, target, dp);
        }

        public int NumRollsRec(int n, int k, int target, int[][] dp)
        {
            if (n * k < target || n > target)
                return 0;
            if (target == n)
                return 1;
            if (n == 0)
                return 0;

            if (dp[n][target] != -1)
                return dp[n][target];

            long result = 0;
            for (int i = 1; i <= k; ++i)
            {
                result = (result + NumRollsRec(n - 1, k, target - i, dp)) % _mod;
            }

            dp[n][target] = (int)result;
            return dp[n][target];
        }
    }
}
