using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2428 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 6, 2, 1, 3 }, new[] { 4, 2, 1, 5 }, new[] { 9, 2, 8, 7 }, new[] { 4, 1, 2, 9 } };

            var expected = 30;

            var result = MaxSum(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxSum(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = 0;

            for (int i = 1; i < n - 1; ++i)
            {
                for (int j = 1; j < m - 1; ++j)
                {
                    result = Math.Max(result, grid[i - 1][j - 1] + grid[i - 1][j] + grid[i - 1][j + 1] + grid[i][j] + grid[i + 1][j - 1] + grid[i + 1][j] + grid[i + 1][j + 1]);
                }
            }

            return result;
        }
    }
}
