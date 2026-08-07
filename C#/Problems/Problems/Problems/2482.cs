using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2482 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 1, 1 }, new[] { 1, 0, 1 }, new[] { 0, 0, 1 } };

            var expected = new[] { new[] { 0, 0, 4 }, new[] { 0, 0, 4 }, new[] { -2, -2, 2 } };

            var result = OnesMinusZeros(grid);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] OnesMinusZeros(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var rowOnes = new int[n];
            var rowZeros = new int[n];
            var colOnes = new int[m];
            var colZeros = new int[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 0)
                    {
                        rowZeros[i]++;
                        colZeros[j]++;
                    }
                    else if (grid[i][j] == 1)
                    {
                        rowOnes[i]++;
                        colOnes[j]++;
                    }
                }
            }
            var result = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                result[i] = new int[m];
                for (int j = 0; j < m; ++j)
                    result[i][j] = rowOnes[i] + colOnes[j] - rowZeros[i] - colZeros[j];
            }

            return result;
        }
    }
}
