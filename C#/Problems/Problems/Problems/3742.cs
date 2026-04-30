using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3742 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 1 }, new[] { 1, 2 } };
            var k = 1;

            var expected = -1;

            var result = MaxPathScore(grid, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxPathScore(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var dp = new int[k + 1][][];
            for (int i = 0; i <= k; ++i)
            {
                dp[i] = new int[n][];
                for (int j = 0; j < n; ++j)
                    dp[i][j] = new int[m];
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i == 0 && j == 0)
                        continue;
                    var cur = grid[i][j];
                    for (int l = 0; l <= k; ++l)
                    {
                        var prev = l - Math.Min(cur, 1);
                        if (prev < 0)
                            dp[l][i][j] = -1;
                        else
                        {
                            var up = i > 0 ? dp[prev][i - 1][j] : -1;
                            var left = j > 0 ? dp[prev][i][j - 1] : -1;
                            if (up != -1 || left != -1)
                                dp[l][i][j] = Math.Max(up, left) + cur;
                            else
                                dp[l][i][j] = -1;
                        }
                    }
                }
            }

            var result = -1;
            for (int i = 0; i <= k; ++i)
                result = Math.Max(result, dp[i][n - 1][m - 1]);

            return result;
        }
    }
}
