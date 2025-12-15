using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2110 : IProblem
    {
        public bool Test()
        {
            var prices = new[] { 3, 2, 1, 4 };

            var expected = 7;

            var result = GetDescentPeriods(prices);

            Console.WriteLine(result);

            return expected == result;
        }

        public long GetDescentPeriods(int[] prices)
        {
            var n = prices.Length;
            long result = 0;
            var start = 0;
            for (int i = 1; i < n; ++i)
            {
                if (prices[i - 1] - prices[i] != 1)
                {
                    long l = i - start;
                    result += l * (l + 1) / 2;
                    start = i;
                }
            }
            long fl = n - start;
            result += fl * (fl + 1) / 2;

            return result;
        }
    }
}
