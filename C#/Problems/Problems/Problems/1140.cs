using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1140 : IProblem
    {
        public bool Test()
        {
            var piles = new[] { 2, 7, 9, 4, 4 };

            var expected = 10;

            var result = StoneGameII(piles);

            Console.WriteLine(result);

            return result == expected;
        }

        public int StoneGameII(int[] piles)
        {
            var n = piles.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = Enumerable.Repeat(-1, n + 1).ToArray();
            var pref = new int[n + 1];
            for (int i = 0; i < n; ++i)
                pref[i + 1] = pref[i] + piles[i];
            return (pref[n] + GameRec(dp, pref, piles, n, 0, 1)) / 2;
        }

        private int GameRec(int[][] dp, int[] pref, int[] piles, int n, int id, int m)
        {
            if (id >= n)
                return 0;
            if (dp[id][m] != -1)
                return dp[id][m];
            var best = int.MinValue;
            for (int i = 1; i <= 2 * m; ++i)
            {
                if (id + i > n)
                    break;
                var take = pref[id + i] - pref[id];
                var res = take - GameRec(dp, pref, piles, n, id + i, Math.Max(m, i));
                best = Math.Max(best, res);
            }
            dp[id][m] = best;
            return best;
        }
    }
}
