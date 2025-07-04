using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3128 : IProblem
    {
        public bool Test()
        {
            var grid = new int[][] { new int[] { 0, 1, 0 }, new int[] { 0, 1, 1 }, new int[] { 0, 1, 0 } };

            var expected = 2;

            var result = NumberOfRightTriangles(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        public long NumberOfRightTriangles(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var rows = new int[n];
            var cols = new int[m];

            for (int i = 0; i < n; ++i)
            {
                for (int j = m - 1; j >= 0; --j)
                {
                    if (grid[i][j] == 1)
                    {
                        rows[i]++;
                        cols[j]++;
                    }
                }
            }

            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] != 0 && rows[i] > 1 && cols[j] > 1)
                    {
                        result += (rows[i] - 1) * (cols[j] - 1);
                    }
                }
            }

            return result;
        }
    }
}
