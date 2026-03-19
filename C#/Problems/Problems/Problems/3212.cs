using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3212 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 'X', 'Y', '.' }, new[] { 'Y', '.', '.' } };

            var expected = 3;

            var result = NumberOfSubmatrices(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfSubmatrices(char[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var xs = new int[n][];
            var ys = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                xs[i] = new int[m];
                ys[i] = new int[m];
            }

            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var upx = i > 0 ? xs[i - 1][j] : 0;
                    var leftx = j > 0 ? xs[i][j - 1] : 0;
                    var lastx = i > 0 && j > 0 ? xs[i - 1][j - 1] : 0;
                    xs[i][j] = upx + leftx - lastx + (grid[i][j] == 'X' ? 1 : 0);
                    var upy = i > 0 ? ys[i - 1][j] : 0;
                    var lefty = j > 0 ? ys[i][j - 1] : 0;
                    var lasty = i > 0 && j > 0 ? ys[i - 1][j - 1] : 0;
                    ys[i][j] = upy + lefty - lasty + (grid[i][j] == 'Y' ? 1 : 0);
                    if (xs[i][j] != 0 && xs[i][j] == ys[i][j])
                        result++;
                }
            }

            return result;
        }
    }
}
