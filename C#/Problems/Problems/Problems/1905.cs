using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1905 : IProblem
    {
        public bool Test()
        {
            var grid1 = new[] {new[] {1, 1, 1, 0, 0}, new[] {0, 1, 1, 1, 1}, new[] {0, 0, 0, 0, 0}, new[] {1, 0, 0, 0, 0}, new[] {1, 1, 0, 1, 1}};
            var grid2 = new[] {new[] {1, 1, 1, 0, 0}, new[] {0, 0, 1, 1, 1}, new[] {0, 1, 0, 0, 0}, new[] {1, 0, 1, 1, 0}, new[] {0, 1, 0, 1, 0}};

            var expected = 3;

            var result = CountSubIslands(grid1, grid2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountSubIslands(int[][] grid1, int[][] grid2)
        {
            var n = grid1.Length;
            var m = grid1[0].Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid2[i][j] == 0)
                        continue;
                    var isSub = true;
                    var que = new Queue<(int X, int Y)>();
                    que.Enqueue((i, j));
                    grid2[i][j] = 0;
                    while (que.Count > 0)
                    {
                        var (x, y) = que.Dequeue();
                        if (grid1[x][y] != 1)
                            isSub = false;
                        if (x - 1 >= 0 && grid2[x - 1][y] == 1)
                        {
                            grid2[x - 1][y] = 0;
                            que.Enqueue((x - 1, y));
                        }
                        if (y - 1 >= 0 && grid2[x][y - 1] == 1)
                        {
                            grid2[x][y - 1] = 0;
                            que.Enqueue((x, y - 1));
                        }
                        if (x + 1 < n && grid2[x + 1][y] == 1)
                        {
                            grid2[x + 1][y] = 0;
                            que.Enqueue((x + 1, y));
                        }
                        if (y + 1 < m && grid2[x][y + 1] == 1)
                        {
                            grid2[x][y + 1] = 0;
                            que.Enqueue((x, y + 1));
                        }
                    }
                    if (isSub)
                        result++;
                }
            }

            return result;
        }
    }
}
