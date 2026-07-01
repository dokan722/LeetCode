using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2812 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 0 }, new[] { 0, 0, 1 } };

            var expected = 0;

            var result = MaximumSafenessFactor(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumSafenessFactor(IList<IList<int>> grid)
        {
            var n = grid.Count;
            var dists = new int[n][];
            for (int i = 0; i < n; ++i)
                dists[i] = Enumerable.Repeat(-1, n).ToArray();
            var queue = new Queue<(int X, int Y)>();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (grid[i][j] == 1)
                    {
                        dists[i][j] = 0;
                        queue.Enqueue((i, j));
                    }
                }
            }
            queue.Enqueue((-1, -1));
            var dist = 1;
            while (queue.Count > 0)
            {
                var next = queue.Dequeue();
                if (next == (-1, -1))
                {
                    dist++;
                    if (queue.Count > 0)
                        queue.Enqueue((-1, -1));
                }
                else
                {
                    if (next.X > 0 && dists[next.X - 1][next.Y] == -1)
                    {
                        dists[next.X - 1][next.Y] = dist;
                        queue.Enqueue((next.X - 1, next.Y));
                    }
                    if (next.Y > 0 && dists[next.X][next.Y - 1] == -1)
                    {
                        dists[next.X][next.Y - 1] = dist;
                        queue.Enqueue((next.X, next.Y - 1));
                    }
                    if (next.X < n - 1 && dists[next.X + 1][next.Y] == -1)
                    {
                        dists[next.X + 1][next.Y] = dist;
                        queue.Enqueue((next.X + 1, next.Y));
                    }
                    if (next.Y < n - 1 && dists[next.X][next.Y + 1] == -1)
                    {
                        dists[next.X][next.Y + 1] = dist;
                        queue.Enqueue((next.X, next.Y + 1));
                    }
                }
            }
            var result = dists[0][0];
            var prio = new PriorityQueue<(int X, int Y), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            var visited = new bool[n][];
            for (int i = 0; i < n; ++i)
                visited[i] = new bool[n];
            prio.Enqueue((0, 0), dists[0][0]);
            visited[0][0] = true;
            while (prio.TryDequeue(out var pos, out var d))
            {
                result = Math.Min(d, result);
                if (pos.X == n - 1 && pos.Y == n - 1)
                    return result;
                if (pos.X > 0 && !visited[pos.X - 1][pos.Y])
                {
                    visited[pos.X - 1][pos.Y] = true;
                    prio.Enqueue((pos.X - 1, pos.Y), dists[pos.X - 1][pos.Y]);
                }
                if (pos.Y > 0 && !visited[pos.X][pos.Y - 1])
                {
                    visited[pos.X][pos.Y - 1] = true;
                    prio.Enqueue((pos.X, pos.Y - 1), dists[pos.X][pos.Y - 1]);
                }
                if (pos.X < n - 1 && !visited[pos.X + 1][pos.Y])
                {
                    visited[pos.X + 1][pos.Y] = true;
                    prio.Enqueue((pos.X + 1, pos.Y), dists[pos.X + 1][pos.Y]);
                }
                if (pos.Y < n - 1 && !visited[pos.X][pos.Y + 1])
                {
                    visited[pos.X][pos.Y + 1] = true;
                    prio.Enqueue((pos.X, pos.Y + 1), dists[pos.X][pos.Y + 1]);
                }
            }

            return result;
        }
    }
}
