using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2373 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 9, 9, 8, 1 }, new[] { 5, 6, 2, 6 }, new[] { 8, 2, 6, 4 }, new[] { 6, 2, 2, 2 } };

            var expected = new[] { new[] { 9, 9 }, new[] { 8, 6 } };

            var result = LargestLocal(grid);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] LargestLocal(int[][] grid)
        {
            var n = grid.Length;
            var result = new int[n - 2][];
            for (int i = 0; i < n - 2; ++i)
                result[i] = new int[n - 2];
            for (int i = 1; i < n - 1; ++i)
            {
                for (int j = 1; j < n - 1; ++j)
                {
                    var mx = 0;
                    for (int k = -1; k <= 1; ++k)
                    {
                        for (int l = -1; l <= 1; ++l)
                        {
                            mx = Math.Max(mx, grid[i - k][j - l]);
                        }
                    }
                    result[i - 1][j - 1] = mx;
                }
            }
            return result;
        }
    }
}
