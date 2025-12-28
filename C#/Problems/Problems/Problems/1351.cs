using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1351 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {4, 3, 2, -1}, new[] {3, 2, 1, -1}, new[] {1, 1, -1, -2}, new[] {-1, -1, -2, -3}};

            var expected = 8;

            var result = CountNegatives(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountNegatives(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var i = n - 1;
            var result = 0;
            for (var j = 0; j < m; ++j)
            {
                if (grid[i][j] < 0)
                {
                    result += j;
                    j--;
                    i--;
                    if (i < 0)
                        break;
                }
            }

            result = n * m - (result + (i + 1) * m);
            return result;
        }
    }
}
