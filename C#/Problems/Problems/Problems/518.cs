using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _518 : IProblem
    {
        public bool Test()
        {
            var amount = 5;
            var coins = new[] { 1, 2, 5 };

            var expected = 4;

            var result = Change(amount, coins);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Change(int amount, int[] coins)
        {
            var dp = new int[amount + 1];
            dp[0] = 1;
            var n = coins.Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = coins[i]; j <= amount; ++j)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }

            return dp[amount];
        }
    }
}
