using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3286 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 1, 0, 0, 0 }, new[] { 0, 1, 0, 1, 0 }, new[] { 0, 0, 0, 1, 0 } };
            var health = 1;

            var expected = true;

            var result = FindSafeWalk(grid, health);

            return result == expected;
        }

        public bool FindSafeWalk(IList<IList<int>> grid, int health)
        {
            if (grid[0][0] == 1)
                health--;
            var dirs = new[] { new[] { 1, 0 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 0, -1 } };
            var n = grid.Count;
            var m = grid[0].Count;
            var visited = new bool[n][];
            for (int i = 0; i < n; ++i)
                visited[i] = new bool[m];
            var curq = new Queue<(int X, int Y)>();
            var nextq = new Queue<(int X, int Y)>();
            curq.Enqueue((0, 0));
            visited[0][0] = true;
            while (health > 0 && (curq.Count > 0 || nextq.Count > 0))
            {
                if (curq.Count == 0)
                {
                    health--;
                    curq = nextq;
                    nextq = new Queue<(int X, int Y)>();
                }
                else
                {
                    var next = curq.Dequeue();
                    if (next.X == n - 1 && next.Y == m - 1)
                        return true;
                    foreach (var dir in dirs)
                    {
                        var x = next.X + dir[0];
                        var y = next.Y + dir[1];
                        if (x >= 0 && x < n && y >= 0 && y < m && !visited[x][y])
                        {
                            visited[x][y] = true;
                            if (grid[x][y] == 0)
                                curq.Enqueue((x, y));
                            else
                                nextq.Enqueue((x, y));
                        }
                    }
                }
            }

            return false;
        }
    }
}
