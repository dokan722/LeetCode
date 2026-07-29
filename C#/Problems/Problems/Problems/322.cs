using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _322 : IProblem
    {
        public bool Test()
        {
            var coins = new[] { 1, 2, 5 };
            var amount = 11;

            var expected = 3;

            var result = CoinChange(coins, amount);

            Console.WriteLine(expected);

            return result == expected;
        }

        public int CoinChange(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            for (int i = 1; i <= amount; ++i)
            {
                dp[i] = int.MaxValue;
                foreach (var c in coins)
                {
                    var req = i - c;
                    if (req >= 0 && dp[req] != int.MaxValue)
                        dp[i] = Math.Min(dp[i], dp[req] + 1);
                }
            }
            return dp[amount] == int.MaxValue ? -1 : dp[amount];
        }
    }
}
