using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1391 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 4, 1 }, new[] { 6, 1 } };

            var expected = true;

            var result = HasValidPath(grid);

            return result == expected;
        }

        public bool HasValidPath(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var paths = new int[][][] {
                new int[][] {},
                new int[][] {new[] {0, -1}, new[] {0, 1} },
                new int[][] {new[] {1, 0}, new[] {-1, 0} },
                new int[][] {new[] {0, -1}, new[] {1, 0} },
                new int[][] {new[] {0, 1}, new[] {1, 0} },
                new int[][] {new[] {0, -1}, new[] {-1, 0} },
                new int[][] {new[] {-1, 0}, new[] {0, 1} }
            };
            var stack = new Stack<(int X, int Y, int PX, int PY)>();
            stack.Push((0, 0, paths[grid[0][0]][0][0], paths[grid[0][0]][0][1]));
            while (stack.Count > 0)
            {
                var top = stack.Pop();
                if (top.X < 0 || top.X >= n || top.Y < 0 || top.Y >= m || grid[top.X][top.Y] == 0)
                    continue;
                var ps = paths[grid[top.X][top.Y]];
                if (!((top.PX == top.X + ps[0][0] && top.PY == top.Y + ps[0][1]) || (top.PX == top.X + ps[1][0] && top.PY == top.Y + ps[1][1])))
                    continue;
                if (top.X == n - 1 && top.Y == m - 1)
                    return true;
                foreach (var ng in ps)
                {
                    stack.Push((top.X + ng[0], top.Y + ng[1], top.X, top.Y));
                }
                grid[top.X][top.Y] = 0;
            }
            return false;
        }
    }
}
