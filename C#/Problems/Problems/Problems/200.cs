using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _200 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {'1','1','1','1','0'}, new[] {'1','1','0','1','0'}, new[] {'1','1','0','0','0'}, new[] {'0','0','0','0','0'}};

            var expected = 1;

            var result = NumIslands(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumIslands(char[][] grid)
        {
            var result = 0;
            var n = grid.Length;
            var m = grid[0].Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] == '1')
                    {
                        result++;
                        var queue = new Queue<(int X, int Y)>();
                        queue.Enqueue((i, j));
                        while (queue.Count > 0)
                        {
                            var top = queue.Dequeue();
                            if (top.X < 0 || top.X >= n || top.Y < 0 || top.Y >= m || grid[top.X][top.Y] != '1')
                                continue;
                            grid[top.X][top.Y] = '2';
                            queue.Enqueue((top.X - 1, top.Y));
                            queue.Enqueue((top.X, top.Y - 1));
                            queue.Enqueue((top.X + 1, top.Y));
                            queue.Enqueue((top.X, top.Y + 1));
                        }
                    }
                }
            }

            return result;
        }
    }
}
