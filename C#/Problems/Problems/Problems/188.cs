using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _188 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 3, 2, 6, 5, 0, 3 };
            var k = 2;

            var expected = 7;

            var result = MaxProfit(k, prices);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProfit(int k, int[] prices)
        {
            var n = prices.Length;
            var noneDp = new int[k + 1];
            var buyingDp = Enumerable.Repeat(-prices[0], k + 1).ToArray();
            buyingDp[0] = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = k; j > 0; --j)
                {
                    noneDp[j] = Math.Max(noneDp[j], buyingDp[j] + prices[i]);
                    buyingDp[j] = Math.Max(buyingDp[j], noneDp[j - 1] - prices[i]);
                }
            }

            return noneDp[k];
        }
    }
}
