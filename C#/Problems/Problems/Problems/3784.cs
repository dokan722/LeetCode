using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3784 : IProblem
    {
        public bool Test()
        {
            var s = "aabaac";
            var cost = new[] { 1, 2, 3, 4, 1, 10 };

            var expected = 11;

            var result = MinCost(s, cost);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MinCost(string s, int[] cost)
        {
            var n = s.Length;
            long total = 0;
            long mx = 0;
            var costs = new long[26];
            for (int i = 0; i < n; ++i)
            {
                costs[s[i] - 'a'] += cost[i];
                total += cost[i];
            }
            for (int i = 0; i < 26; ++i)
                mx = Math.Max(mx, costs[i]);
            return total - mx;
        }
    }
}
