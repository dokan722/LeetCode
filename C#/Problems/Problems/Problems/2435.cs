using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2435 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 5, 2, 4 }, new[] { 3, 0, 5 }, new[] { 0, 7, 2 } };
            var k = 3;

            var expected = 2;

            var result = NumberOfPaths(grid, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfPaths(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var mod = 1000000007;
            var dp = new int[n][][];
            for (int i = 0; i < n; ++i)
            {
                dp[i] = new int[m][];
                for (int j = 0; j < n; ++j)
                    dp[i][j] = new int[k];
            }

            dp[0][0][grid[0][0] % k] = 1;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    for (int l = 0; l < k; ++l)
                    {
                        dp[i][j][(l + grid[i][j]) % k] += ((i > 0 ? dp[i - 1][j][l] : 0) + (j > 0 ? dp[i][j - 1][l] : 0)) % mod;
                    }
                }
            }

            return dp[n - 1][m - 1][0];
        }
    }
}
