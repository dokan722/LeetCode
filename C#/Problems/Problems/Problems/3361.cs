using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3361 : IProblem
    {
        public bool Test()
        {
            var s = "abab";
            var t = "baba";
            var nextCost = new[] { 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var previousCost = new[] { 1, 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            var expected = 2;

            var result = ShiftDistance(s, t, nextCost, previousCost);

            Console.WriteLine(result);

            return result == expected;
        }

        public long ShiftDistance(string s, string t, int[] nextCost, int[] previousCost)
        {
            long result = 0;
            var forw = new long[27];
            var backw = new long[27];
            for (int i = 0; i < 26; ++i)
            {
                forw[i + 1] = nextCost[i] + forw[i];
                backw[i + 1] = previousCost[25 - i] + backw[i];
            }
            var n = s.Length;
            for (int i = 0; i < n; ++i)
            {
                var x = s[i] - 'a';
                var y = t[i] - 'a';
                var f = (x < y ? forw[y] - forw[x] : forw[26] - forw[x] + forw[y]);
                var b = (x < y ? backw[26] - backw[25 - x] + backw[25 - y] : backw[25 - y] - backw[25 - x]);
                result += Math.Min(f, b);
            }

            return result;
        }
    }
}
