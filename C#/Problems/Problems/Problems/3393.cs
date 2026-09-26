using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3393 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 2, 1, 5 }, new[] { 7, 10, 0 }, new[] { 12, 6, 4 } };
            var k = 11;

            var expected = 3;

            var result = CountPathsWithXorValue(grid, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountPathsWithXorValue(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var mod = 1000000007;
            var limit = 16;
            var dp = new long[n][][];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = new long[m][];
                for (int j = 0; j < m; ++j)
                    dp[i][j] = new long[limit];
            }
            dp[0][0][grid[0][0]] = 1;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    for (int l = 0; l < limit; ++l)
                    {
                        var next = l ^ grid[i][j];
                        var up = i > 0 ? dp[i - 1][j][l] : 0;
                        var left = j > 0 ? dp[i][j - 1][l] : 0;
                        dp[i][j][next] = (dp[i][j][next] + up + left) % mod;
                    }
                }
            }

            return (int)dp[n - 1][m - 1][k];
        }
    }
}
