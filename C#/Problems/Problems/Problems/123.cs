using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _123 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 3, 3, 5, 0, 0, 3, 1, 4 };

            var expected = 6;

            var result = MaxProfit(prices);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProfit(int[] prices)
        {
            var n = prices.Length;
            var empty = new int[3];
            var buying = Enumerable.Repeat(-prices[0], 3).ToArray();
            for (int i = 1; i < n; ++i)
            {
                empty[2] = Math.Max(empty[2], buying[2] + prices[i]);
                buying[2] = Math.Max(buying[2], empty[1] - prices[i]);
                empty[1] = Math.Max(empty[1], buying[1] + prices[i]);
                buying[1] = Math.Max(buying[1], empty[0] - prices[i]);
            }

            return empty[2];
        }
    }
}
