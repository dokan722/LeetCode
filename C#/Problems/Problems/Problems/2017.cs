using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2017 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 2, 5, 4 }, new[] { 1, 5, 1 } };

            var expected = 4;

            var result = GridGame(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public long GridGame(int[][] grid)
        {
            var n = grid[0].Length;
            var sums = new long[] { 0, 0 };
            for (int i = 0; i < n; i++)
            {
                sums[0] += grid[0][i];
                sums[1] += grid[1][i];
            }

            var result = sums[0] - grid[0][0];
            var prefs = new long[] { grid[0][0], 0 };
            for (int i = 1; i < n; i++)
            {
                prefs[0] += grid[0][i];
                prefs[1] += grid[1][i - 1];
                result = Math.Min(result, Math.Max(sums[0] - prefs[0], prefs[1]));
            }

            return result;
        }
    }
}
