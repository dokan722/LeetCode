using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _877 : IProblem
    {
        public bool Test()
        {
            var piles = new[] { 7, 8, 8, 10 };

            var expected = true;

            var result = StoneGame(piles);

            return expected == result;
        }

        public bool StoneGame(int[] piles)
        {
            var n = piles.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = Enumerable.Repeat(int.MinValue, n).ToArray();
            return StoneGameRec(piles, dp, 0, n - 1, true) > 0;
        }

        private int StoneGameRec(int[] piles, int[][] dp, int i, int j, bool aliceTurn)
        {
            if (i == j)
                return -piles[i];
            if (dp[i][j] != int.MinValue)
                return dp[i][j];
            var fromLeft = StoneGameRec(piles, dp, i + 1, j, !aliceTurn) + (aliceTurn ? piles[i] : -piles[i]);
            var fromRight = StoneGameRec(piles, dp, i, j - 1, !aliceTurn) + (aliceTurn ? piles[j] : -piles[j]);
            dp[i][j] = aliceTurn ? Math.Max(fromLeft, fromRight) : Math.Min(fromLeft, fromRight);
            return dp[i][j];
        }
    }
}
