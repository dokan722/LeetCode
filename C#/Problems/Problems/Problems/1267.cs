using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1267 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 0 }, new[] { 1, 1 } };

            var expected = 3;

            var result = CountServers(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountServers(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var rows = new int[n];
            var cols = new int[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        rows[i]++;
                        cols[j]++;
                    }
                }
            }
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 1 && (rows[i] > 1 || cols[j] > 1))
                        result++;
                }
            }

            return result;
        }
    }
}
