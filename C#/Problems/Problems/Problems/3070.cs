using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3070 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 7, 6, 3 }, new[] { 6, 6, 1 } };
            var k = 18;

            var expected = 4;

            var result = CountSubmatrices(grid, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountSubmatrices(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var top = i > 0 ? grid[i - 1][j] : 0;
                    var left = j > 0 ? grid[i][j - 1] : 0;
                    var last = i > 0 && j > 0 ? grid[i - 1][j - 1] : 0;
                    grid[i][j] = grid[i][j] + top + left - last;
                    if (grid[i][j] <= k)
                        result++;
                    else
                        break;
                }
            }

            return result;
        }
    }
}
