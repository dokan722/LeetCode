using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3619 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {0, 2, 1, 0, 0}, new[] {0, 5, 0, 0, 5}, new[] {0, 0, 1, 0, 0}, new[] {0, 1, 4, 7, 0}, new[] {0, 2, 0, 0, 8}};
            var k = 5;

            var expected = 2;

            var result = CountIslands(grid, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountIslands(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var dirs = new (int X, int Y)[] { (0, -1), (0, 1), (-1, 0), (1, 0) };
            var visited = new bool[n][];
            for (int i = 0; i < n; ++i)
                visited[i] = new bool[m];
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 0 || visited[i][j])
                        continue;
                    var q = new Queue<(int, int)>();
                    q.Enqueue((i, j));
                    visited[i][j] = true;
                    long val = 0;
                    while (q.Count > 0)
                    {
                        var (x, y) = q.Dequeue();
                        val += grid[x][y];
                        foreach (var dir in dirs)
                        {
                            var xn = x + dir.X;
                            var yn = y + dir.Y;
                            if (xn < 0 || xn >= n || yn < 0 || yn >= m || visited[xn][yn] || grid[xn][yn] == 0)
                                continue;
                            q.Enqueue((xn, yn));
                            visited[xn][yn] = true;
                        }
                    }
                    if (val % k == 0)
                        result++;
                }
            }

            return result;
        }
    }
}
