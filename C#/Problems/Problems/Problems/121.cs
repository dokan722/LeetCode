using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _121 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 7, 1, 5, 3, 6, 4 };

            var expected = 5;

            var result = MaxProfit(prices);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxProfit(int[] prices)
        {
            var n = prices.Length;
            var currMin = prices[0];
            var result = 0;
            for (int i = 1; i < n; ++i)
            {
                currMin = Math.Min(currMin, prices[i]);
                result = Math.Max(prices[i] - currMin, result);
            }

            return result;
        }
    }
}
