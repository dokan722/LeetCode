using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1020 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 0, 0, 0 }, new[] { 1, 0, 1, 0 }, new[] { 0, 1, 1, 0 }, new[] { 0, 0, 0, 0 } };

            var expected = 3;

            var result = NumEnclaves(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumEnclaves(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var que = new Queue<(int X, int Y)>();
            var dirs = new[] { new[] { -1, 0 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { 0, 1 } };
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == 0)
                        continue;
                    grid[i][j] = 0;
                    que.Enqueue((i, j));
                    var enc = 1;
                    var exit = false;
                    while (que.Count > 0)
                    {
                        var p = que.Dequeue();
                        foreach (var d in dirs)
                        {
                            var x = p.X + d[0];
                            var y = p.Y + d[1];
                            if (x >= 0 && x < n && y >= 0 && y < m)
                            {
                                if (grid[x][y] == 1)
                                {
                                    grid[x][y] = 0;
                                    enc++;
                                    que.Enqueue((x, y));
                                }
                            }
                            else
                                exit = true;
                        }
                    }
                    if (!exit)
                        result += enc;
                }
            }

            return result;
        }
    }
}
