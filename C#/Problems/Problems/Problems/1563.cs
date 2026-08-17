using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1563 : IProblem
    {
        public bool Test()
        {
            var stoneValue = new[] { 6, 2, 3, 4, 5, 5 };

            var expected = 18;

            var result = StoneGameV(stoneValue);

            Console.WriteLine(result);

            return result == expected;
        }

        public int StoneGameV(int[] stoneValue)
        {
            var n = stoneValue.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = Enumerable.Repeat(-1, n).ToArray();
            var pref = new int[n + 1];
            for (int i = 0; i < n; ++i)
                pref[i + 1] = pref[i] + stoneValue[i];
            return GameDp(dp, pref, stoneValue, 0, n - 1);
        }

        private int GameDp(int[][] dp, int[] pref, int[] arr, int l, int r)
        {
            if (l == r)
                return 0;
            if (dp[l][r] != -1)
                return dp[l][r];
            var total = pref[r + 1] - pref[l];
            var pre = 0;
            var best = 0;
            for (int i = l; i < r; ++i)
            {
                pre += arr[i];
                var suf = total - pre;
                if (pre > suf)
                    best = Math.Max(best, suf + GameDp(dp, pref, arr, i + 1, r));
                else if (pre < suf)
                    best = Math.Max(best, pre + GameDp(dp, pref, arr, l, i));
                else
                    best = Math.Max(best, Math.Max(pre + GameDp(dp, pref, arr, l, i), suf + GameDp(dp, pref, arr, i + 1, r)));
            }
            dp[l][r] = best;
            return best;
        }
    }
}
