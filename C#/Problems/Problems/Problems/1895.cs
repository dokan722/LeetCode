using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1895 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 7, 1, 4, 5, 6 }, new[] { 2, 5, 1, 6, 4 }, new[] { 1, 5, 4, 3, 2 }, new[] { 1, 2, 7, 3, 4 } };

            var expected = 3;

            var result = LargestMagicSquare(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LargestMagicSquare(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var rowPrefixes = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                rowPrefixes[i] = new int[m + 1];
                for (int j = 0; j < m; ++j)
                {
                    rowPrefixes[i][j + 1] = rowPrefixes[i][j] + grid[i][j];
                }
            }
            var columnPrefixes = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                columnPrefixes[i] = new int[n + 1];
                for (int j = 0; j < n; ++j)
                {
                    columnPrefixes[i][j + 1] = columnPrefixes[i][j] + grid[j][i];
                }
            }

            var start = Math.Min(n, m);

            for (int i = start; i > 1; --i)
            {
                var vertical = n - i + 1;
                var horizontal = m - i + 1;
                for (int h = 0; h < vertical; ++h)
                {
                    for (int w = 0; w < horizontal; ++w)
                    {
                        var works = true;
                        var req = rowPrefixes[h][w + i] - rowPrefixes[h][w]; 
                        for (int r = 1; r < i; ++r)
                        {
                            if (req != rowPrefixes[h + r][w + i] - rowPrefixes[h + r][w])
                            {
                                works = false;
                                break;
                            }
                        }
                        if (!works)
                            continue;
                        for (int c = 0; c < i; ++c)
                        {
                            if (req != columnPrefixes[w + c][h + i] - columnPrefixes[w + c][h])
                            {
                                works = false;
                                break;
                            }
                        }

                        if (!works)
                            continue;
                        var diag1 = 0;
                        var diag2 = 0;
                        for (int d = 0; d < i; ++d)
                        {
                            diag1 += grid[h + d][w + d];
                            diag2 += grid[h + d][w + i - d - 1];
                        }

                        if (diag1 == req && diag2 == req)
                            return i;
                    }
                }
            }

            return 1;
        }
    }
}
