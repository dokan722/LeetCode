using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2561 : IProblem
    {
        public bool Test()
        {
            var basket1 = new[] { 4, 2, 2, 2 };
            var basket2 = new[] { 1, 4, 1, 2 };

            long expected = 1;

            var result = MinCost(basket1, basket2);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MinCost(int[] basket1, int[] basket2)
        {
            var n = basket1.Length;
            var counts1 = new Dictionary<int, int>();
            var counts2 = new Dictionary<int, int>();
            var minConst = int.MaxValue;
            for (int i = 0; i < n; ++i)
            {
                if (counts1.ContainsKey(basket1[i]))
                    counts1[basket1[i]]++;
                else
                {
                    counts1[basket1[i]] = 1;
                    counts2[basket1[i]] = 0;
                }
                if (counts2.ContainsKey(basket2[i]))
                    counts2[basket2[i]]++;
                else
                {
                    counts2[basket2[i]] = 1;
                    counts1[basket2[i]] = 0;
                }
                if (basket1[i] < minConst)
                    minConst = basket1[i];
                if (basket2[i] < minConst)
                    minConst = basket2[i];
            }

            var first = new List<int>();
            var second = new List<int>();
            foreach (var key in counts1.Keys)
            {
                var toSwap = counts1[key] - counts2[key];
                if (toSwap % 2 != 0)
                    return -1;
                if (toSwap > 0)
                    first.AddRange(Enumerable.Repeat(key, toSwap / 2));
                else if (toSwap < 0)
                    second.AddRange(Enumerable.Repeat(key, -toSwap / 2));
            }
            first.Sort();
            second.Sort();

            long result = 0;
            var m = first.Count;
            for (int i = 0; i < m; i++)
            {
                result += Math.Min(Math.Min(first[i], second[m - 1 - i]), 2 * minConst);
            }

            return result;
        }
    }
}
