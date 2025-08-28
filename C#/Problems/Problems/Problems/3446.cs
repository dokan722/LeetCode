using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3446 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 7, 3 }, new[] { 9, 8, 2 }, new[] { 4, 5, 6 } };

            var expected = new[] { new[] { 8, 2, 3 }, new[] { 9, 6, 7 }, new[] { 4, 5, 1 } };

            var result = SortMatrix(grid);

            if (result.Length != expected.Length)
                return false;
            for (int i = 0; i < result.Length; ++i)
            {
                if (!result[i].SequenceEqual(expected[i]))
                    return false;
            }

            return true;
        }

        public int[][] SortMatrix(int[][] grid)
        {
            var n = grid.Length;

            for (int i = 0; i < n; ++i)
            {
                var helper = new int[i + 1];
                for (int j = 0; j <= i; ++j)
                    helper[j] = grid[n - 1 - i + j][j];
                Array.Sort(helper, (a, b) => b.CompareTo(a));
                for (int j = 0; j <= i; ++j)
                    grid[n - 1 - i + j][j] = helper[j];
            }

            for (int i = 0; i < n - 1; ++i)
            {
                var helper = new int[i + 1];
                for (int j = 0; j <= i; ++j)
                    helper[j] = grid[j][n - 1 - i + j];
                Array.Sort(helper);
                for (int j = 0; j <= i; ++j)
                    grid[j][n - 1 - i + j] = helper[j];
            }

            return grid;
        }
    }
}
