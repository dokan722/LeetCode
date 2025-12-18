using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3652 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 4, 2, 8 };
            var strategy = new[] { -1, 0, 1 };
            var k = 2;

            var expected = 10;

            var result = MaxProfit(prices, strategy, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxProfit(int[] prices, int[] strategy, int k)
        {
            var n = prices.Length;
            var half = k / 2;
            long total = 0;
            long currDiff = 0;
            long bestDiff = 0;
            for (int i = 0; i < n; ++i)
            {
                var curr = prices[i] * strategy[i];
                total += curr;
                currDiff += prices[i] - curr;
                if (i >= half)
                {
                    currDiff -= prices[i - half];
                }
                if (i >= k - 1)
                {
                    if (i >= k)
                        currDiff += prices[i - k] * strategy[i - k];
                    bestDiff = Math.Max(bestDiff, currDiff);
                }
            }

            return total + bestDiff;
        }
    }
}
