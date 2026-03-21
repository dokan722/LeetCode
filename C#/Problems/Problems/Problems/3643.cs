using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3643 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {1, 2, 3, 4}, new[] {5, 6, 7, 8}, new[] {9, 10, 11, 12}, new[] {13, 14, 15, 16}};
            var x = 1;
            var y = 0;
            var k = 3;

            var expected = new[] {new[] {1, 2, 3, 4}, new[] {13, 14, 15, 8}, new[] {9, 10, 11, 12}, new[] {5, 6, 7, 16}};

            var result = ReverseSubmatrix(grid, x, y, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }
        public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
        {
            var swaps = k / 2;
            for (int i = 0; i < swaps; ++i)
            {
                var up = x + i;
                var down = x + k - i - 1;
                for (int j = 0; j < k; ++j)
                    (grid[down][y + j], grid[up][y + j]) = (grid[up][y + j], grid[down][y + j]);
            }

            return grid;
        }
    }
}
