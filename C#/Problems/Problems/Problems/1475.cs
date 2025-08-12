using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1475 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 8, 4, 6, 2, 3 };

            var expected = new[] { 4, 2, 4, 2, 3 };

            var result = FinalPrices(prices);

            return expected.SequenceEqual(result);
        }

        public int[] FinalPrices(int[] prices)
        {
            var n = prices.Length;

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
                    prices[stack.Pop()] -= prices[i];
                stack.Push(i);
            }

            return prices;
        }
    }
}
