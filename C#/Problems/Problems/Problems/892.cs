using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _892 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } };

            var expected = 32;

            var result = SurfaceArea(grid);

            Console.WriteLine(result);

            return result == expected;
        }
        public int SurfaceArea(int[][] grid)
        {
            var result = 0;
            var n = grid.Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    var up = i == 0 ? grid[i][j] : Math.Max(0, grid[i][j] - grid[i - 1][j]);
                    var down = i == n - 1 ? grid[i][j] : Math.Max(0, grid[i][j] - grid[i + 1][j]);
                    var left = j == 0 ? grid[i][j] : Math.Max(0, grid[i][j] - grid[i][j - 1]);
                    var right = j == n - 1 ? grid[i][j] : Math.Max(0, grid[i][j] - grid[i][j + 1]);
                    var rest = grid[i][j] == 0 ? 0 : 2;
                    result += up + down + left + right + rest;
                }
            }
            return result;
        }

    }
}
