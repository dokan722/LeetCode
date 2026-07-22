using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1260 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            var k = 1;

            var expected = new[] { new[] { 9, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 } };

            var result = ShiftGrid(grid, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            if (k == 0)
                return grid;
            var n = grid.Length;
            var m = grid[0].Length;
            var t = n * m;
            k %= t;
            RevGrid(grid, 0, t - 1, m);
            RevGrid(grid, 0, k - 1, m);
            RevGrid(grid, k, t - 1, m);

            return grid;
        }

        private void RevGrid(int[][] grid, int l, int r, int m)
        {
            while (l < r)
            {
                var lx = l / m;
                var ly = l % m;
                var rx = r / m;
                var ry = r % m;
                (grid[lx][ly], grid[rx][ry]) = (grid[rx][ry], grid[lx][ly]);
                l++;
                r--;
            }
        }
    }
}
