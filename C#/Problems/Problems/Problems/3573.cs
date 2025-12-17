using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3573 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 12, 16, 19, 19, 8, 1, 19, 13, 9 };
            var k = 3;

            var expected = 36;

            var result = MaximumProfit(prices, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumProfit(int[] prices, int k)
        {
            var n = prices.Length;
            var noneDp = new long[k + 1];
            var sellingDp = Enumerable.Repeat((long)prices[0], k + 1).ToArray();
            var buyingDp = Enumerable.Repeat((long)-prices[0], k + 1).ToArray();
            sellingDp[0] = 0;
            buyingDp[0] = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = k; j > 0; --j)
                {
                    noneDp[j] = Math.Max(noneDp[j], Math.Max(buyingDp[j] + prices[i], sellingDp[j] - prices[i]));
                    sellingDp[j] = Math.Max(sellingDp[j], noneDp[j - 1] + prices[i]);
                    buyingDp[j] = Math.Max(buyingDp[j], noneDp[j - 1] - prices[i]);
                }
            }

            return noneDp[k];
        }
    }
}