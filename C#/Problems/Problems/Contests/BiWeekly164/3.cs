using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly164
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 1, 0 }, new[] { 0, 0, 1 }, new[] { 1, 0, 0 } };

            var expected = 5;

            var result = UniquePaths(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int UniquePaths(int[][] grid)
        {
            var mod = 1000000007;
            var n = grid.Length;
            var m = grid[0].Length;
            var fromLeft = new int[n][];
            var fromUp = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                fromLeft[i] = new int[m];
                fromUp[i] = new int[m];
            }

            fromLeft[0][0] = 1;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 0)
                    {
                        if (i != n - 1)
                            fromUp[i + 1][j] = (fromLeft[i][j] + fromUp[i][j]) % mod;
                        if (j != m - 1)
                            fromLeft[i][j + 1] = (fromLeft[i][j] + fromUp[i][j]) % mod;
                    }
                    else
                    {
                        if (i != n - 1)
                            fromUp[i + 1][j] = fromLeft[i][j];
                        if (j != m - 1)
                            fromLeft[i][j + 1] = fromUp[i][j];
                    }
                }
            }

            return (fromLeft[n - 1][m - 1] + fromUp[n - 1][m - 1]) % mod;
        }
    }
}
