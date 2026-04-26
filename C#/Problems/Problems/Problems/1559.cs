using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1559 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[]{'a', 'a', 'a', 'a'}, new[] {'a', 'b', 'b', 'a'}, new[] {'a', 'b', 'b', 'a'}, new[] {'a', 'a', 'a', 'a'}};

            var expected = true;

            var result = ContainsCycle(grid);

            return expected == result;
        }

        public bool ContainsCycle(char[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (grid[i][j] < 'a')
                        continue;
                    var cur = grid[i][j];
                    var stack = new Stack<(int X, int Y, int PX, int PY)>();
                    stack.Push((i, j, -1, -1));
                    while (stack.Count > 0)
                    {
                        var top = stack.Pop();
                        if (top.X < 0 || top.X >= n || top.Y < 0 || top.Y >= m)
                            continue;
                        if (grid[top.X][top.Y] == cur - 'a')
                            return true;
                        if (grid[top.X][top.Y] != cur)
                            continue;
                        if (top.X - 1 != top.PX || top.Y != top.PY)
                            stack.Push((top.X - 1, top.Y, top.X, top.Y));
                        if (top.X + 1 != top.PX || top.Y != top.PY)
                            stack.Push((top.X + 1, top.Y, top.X, top.Y));
                        if (top.X != top.PX || top.Y - 1 != top.PY)
                            stack.Push((top.X, top.Y - 1, top.X, top.Y));
                        if (top.X != top.PX || top.Y + 1 != top.PY)
                            stack.Push((top.X, top.Y + 1, top.X, top.Y));
                        grid[top.X][top.Y] -= 'a';
                    }
                }
            }
            return false;
        }
    }
}
