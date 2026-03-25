using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3546 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 4 }, new[] { 2, 3 } };

            var expected = true;

            var result = CanPartitionGrid(grid);

            return result == expected;
        }

        public bool CanPartitionGrid(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            long s = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    s += grid[i][j];
            }
            if (s % 2 != 0)
                return false;
            var req = s / 2;
            long hor = 0;
            long ver = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    hor += grid[i][j];
                }
                if (hor == req)
                    return true;
            }
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    ver += grid[j][i];
                }
                if (ver == req)
                    return true;
            }


            return false;
        }
    }
}
