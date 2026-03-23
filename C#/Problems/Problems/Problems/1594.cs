using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1594 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, -2, 1 }, new[] { 1, -2, 1 }, new[] { 3, -4, 1 } };

            var expected = 8;

            var result = MaxProductPath(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProductPath(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var mod = 1000000007;
            var dp = new (long Pos, long Neg)[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = new (long Neg, long Pos)[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i == 0 && j == 0)
                    {
                        dp[i][j] = (grid[i][j], grid[i][j]);
                        continue;
                    }
                    var up = i > 0 ? dp[i - 1][j] : (int.MinValue, int.MaxValue);
                    var left = j > 0 ? dp[i][j - 1] : (int.MinValue, int.MaxValue);
                    if (grid[i][j] >= 0)
                    {
                        dp[i][j] = (Math.Max(grid[i][j] * up.Pos, grid[i][j] * left.Pos), Math.Min(grid[i][j] * up.Neg, grid[i][j] * left.Neg));
                    }
                    else
                    {
                        dp[i][j] = (Math.Max(grid[i][j] * up.Neg, grid[i][j] * left.Neg), Math.Min(grid[i][j] * up.Pos, grid[i][j] * left.Pos));
                    }
                }
            }

            return dp[n - 1][m - 1].Pos >= 0 ? (int)(dp[n - 1][m - 1].Pos % mod) : -1;
        }
    }
}
