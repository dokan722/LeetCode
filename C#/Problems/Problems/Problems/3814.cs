using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3814 : IProblem
    {
        public bool Test()
        {
            var costs = new[] { 4, 8, 5, 3 };
            var capacity = new[] { 1, 5, 2, 7 };
            var budget = 8;

            var expected = 8;

            var result = MaxCapacity(costs, capacity, budget);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxCapacity(int[] costs, int[] capacity, int budget)
        {
            var n = costs.Length;
            Array.Sort(costs, capacity);
            var best = new int[n];
            var mx = 0;
            for (int i = 0; i < n; ++i)
            {
                mx = Math.Max(mx, capacity[i]);
                best[i] = mx;
            }
            var result = 0;
            var r = n - 1;
            for (int i = 0; i < n; ++i)
            {
                if (costs[i] >= budget)
                    break;
                var limit = budget - costs[i];
                while (r >= 0 && costs[r] >= limit)
                    r--;
                var j = Math.Min(r, i - 1);
                if (j >= 0)
                    result = Math.Max(result, capacity[i] + best[j]);
                else
                    result = Math.Max(result, capacity[i]);
            }

            return result;
        }
    }
}
