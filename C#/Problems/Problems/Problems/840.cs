using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _840 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 4, 3, 8, 4 }, new[] { 9, 5, 1, 9 }, new[] { 2, 7, 6, 2 } };

            var expected = 1;

            var result = NumMagicSquaresInside(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumMagicSquaresInside(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = 0;

            for (int i = 0; i < n - 2; ++i)
            {
                for (int j = 0; j < m - 2; ++j)
                {
                    var present = new bool[9];
                    var invalid = false;
                    for (int l = 0; l < 9; ++l)
                    {
                        var val = grid[i + l / 3][j + l % 3];
                        if (val < 1 || val > 9)
                        {
                            invalid = true;
                            break;
                        }
                        present[val - 1] = true;
                    }
                    if (!invalid && present.All(x => x) &&
                        grid[i][j] + grid[i][j + 1] + grid[i][j + 2] == 15 &&
                        grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] == 15 &&
                        grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] == 15 &&
                        grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] == 15 &&
                        grid[i][j] + grid[i + 1][j] + grid[i + 2][j] == 15 &&
                        grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] == 15 &&
                        grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] == 15 &&
                        grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j] == 15)
                        result++;
                }
            }

            return result;
        }
    }
}
