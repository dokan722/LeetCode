using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1139 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } };

            var expected = 9;

            var result = Largest1BorderedSquare(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        public int Largest1BorderedSquare(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var horizontal = new int[n][];
            var vertical = new int[n][];
            for (int i = 0; i < n; i++)
            {
                horizontal[i] = new int[m];
                vertical[i] = new int[m];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == 0)
                        horizontal[i][j] = grid[i][j];
                    else
                        horizontal[i][j] = grid[i][j] == 1 ? horizontal[i][j - 1] + 1 : 0;
                    if (i == 0)
                        vertical[i][j] = grid[i][j];
                    else
                        vertical[i][j] = grid[i][j] == 1 ? vertical[i - 1][j] + 1 : 0;
                }
            }

            var result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var maxSide = Math.Min(vertical[i][j], horizontal[i][j]);
                    if (maxSide > result)
                    {
                        for (int k = maxSide; k > result; k--)
                        {
                            if (vertical[i][j - k + 1] >= k && horizontal[i - k + 1][j] >= k)
                            {
                                result = k;
                                break;
                            }
                        }
                    }
                }
            }

            return result * result;
        }
    }
}
