using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _714 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 1, 3, 2, 8, 4, 9 };
            var fee = 2;

            var expected = 8;

            var result = MaxProfit(prices, fee);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProfit(int[] prices, int fee)
        {
            var n = prices.Length;
            var maxNone = 0;
            var maxBought = -prices[0] - fee;
            for (int i = 0; i < n; ++i)
            {
                maxNone = Math.Max(maxNone, maxBought + prices[i]);
                maxBought = Math.Max(maxBought, maxNone - prices[i] - fee);
            }

            return maxNone;
        }
    }
}
