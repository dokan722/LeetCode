using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _64 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 3, 1 }, new[] { 1, 5, 1 }, new[] { 4, 2, 1 } };

            var expected = 7;

            var result = MinPathSum(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinPathSum(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var dp = new int[n][];
            for (var i = 0; i < n; ++i)
                dp[i] = new int[m];
            dp[0][0] = grid[0][0];
            int j = 1;
            for (int i = 0; i < n; ++i)
            {
                for (; j < m; ++j)
                    dp[i][j] = Math.Min(i > 0 ? dp[i - 1][j] : int.MaxValue, j > 0 ? dp[i][j - 1] : int.MaxValue) + grid[i][j];
                j = 0;

            }

            return dp[n - 1][m - 1];
        }
    }
}
