using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2906 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 2 }, new[] { 3, 4 } };

            var expected = new[] { new[] { 24, 12 }, new[] { 8, 6 } };

            var result = ConstructProductMatrix(grid);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] ConstructProductMatrix(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var l = n * m;
            var mod = 12345;
            var prefs = new int[l];
            var sufs = new int[l];
            prefs[0] = grid[0][0] % mod;
            sufs[l - 1] = grid[n - 1][m - 1] % mod;
            for (int i = 1; i < l; ++i)
            {
                prefs[i] = (grid[i / m][i % m] % mod) * (prefs[i - 1] % mod) % mod;
                sufs[l - i - 1] = (grid[n - 1 - (i / m)][m - 1 - (i % m)] % mod) * (sufs[l - i] % mod) % mod;
            }
            var result = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                result[i] = new int[m];
                for (int j = 0; j < m; ++j)
                {
                    if (i == 0 && j == 0)
                    {
                        result[i][j] = sufs[1];
                        continue;
                    }
                    else if (i == n - 1 && j == m - 1)
                    {
                        result[i][j] = prefs[l - 2];
                        continue;
                    }
                    result[i][j] = prefs[i * m + j - 1] * sufs[i * m + j + 1] % mod;
                }
            }
            return result;
        }
    }
}
