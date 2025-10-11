using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3186 : IProblem
    {
        public bool Test()
        {
            var power = new[] { 7, 1, 6, 6 };

            var expected = 13;

            var result = MaximumTotalDamage(power);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MaximumTotalDamage(int[] power)
        {
            var counts = new SortedDictionary<int, int>();
            foreach (var p in power)
            {
                if (counts.ContainsKey(p))
                    counts[p]++;
                else
                    counts[p] = 1;
            }

            var n = counts.Count;
            var values = new int[n];
            var id = 0;
            foreach (var count in counts)
            {
                values[id] = count.Key;
                id++;
            }
            var dp = new long[n];
            long result = 0;
            long mx = 0;
            int j = 0;
            for (int i = 0; i < n; ++i)
            {
                var value = values[i];
                while (j < i && values[j] < value - 2)
                {
                    mx = Math.Max(mx, dp[j]);
                    j++;
                }
                dp[i] = mx + (long)counts[value] * value;
                result = Math.Max(result, dp[i]);
            }

            return result;
        }
    }
}
