using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1254 : IProblem
    {
        public bool Test()
        {
            var grid = new[]
            {
                new[] { 1, 1, 1, 1, 1, 1, 1, 0 }, new[] { 1, 0, 0, 0, 0, 1, 1, 0 }, new[] { 1, 0, 1, 0, 1, 1, 1, 0 },
                new[] { 1, 0, 0, 0, 0, 1, 0, 1 }, new[] { 1, 1, 1, 1, 1, 1, 1, 0 }
            };

            var expected = 2;

            var result = ClosedIsland(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ClosedIsland(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = 0;
            var visited = new bool[n][];
            for (int i = 0; i < n; ++i)
                visited[i] = new bool[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 1 || visited[i][j])
                        continue;
                    var q = new Queue<(int X, int Y)>();
                    q.Enqueue((i, j));
                    visited[i][j] = true;
                    var valid = true;
                    while (q.Count > 0)
                    {
                        var (x, y) = q.Dequeue();
                        if (x == 0)
                            valid = false;
                        else if (!visited[x - 1][y] && grid[x - 1][y] == 0)
                        {
                            q.Enqueue((x - 1, y));
                            visited[x - 1][y] = true;
                        }
                        if (x == n - 1)
                            valid = false;
                        else if (!visited[x + 1][y] && grid[x + 1][y] == 0)
                        {
                            q.Enqueue((x + 1, y));
                            visited[x + 1][y] = true;
                        }
                        if (y == 0)
                            valid = false;
                        else if (!visited[x][y - 1] && grid[x][y - 1] == 0)
                        {
                            q.Enqueue((x, y - 1));
                            visited[x][y - 1] = true;
                        }
                        if (y == m - 1)
                            valid = false;
                        else if (!visited[x][y + 1] && grid[x][y + 1] == 0)
                        {
                            q.Enqueue((x, y + 1));
                            visited[x][y + 1] = true;
                        }
                    }
                    if (valid)
                        result++;
                }
            }

            return result;
        }
    }
}
