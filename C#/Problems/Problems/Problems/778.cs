using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _778 : IProblem
    {
        public bool Test()
        {
            var grid = new[] {new[] {0, 1, 2, 3, 4}, new[] {24, 23, 22, 21, 5}, new[] {12, 13, 14, 15, 16}, new[] {11, 17, 18, 19, 20}, new[] {10, 9, 8, 7, 6}};

            var expected = 16;

            var result = SwimInWater(grid);

            Console.WriteLine(result);

            return expected == result;
        }
        public int SwimInWater(int[][] grid)
        {
            var n = grid.Length;
            var visited = new bool[n][];
            for (int i = 0; i < n; i++)
                visited[i] = new bool[n];
            var queue = new PriorityQueue<(int X, int Y), int>();
            queue.Enqueue((0, 0), grid[0][0]);

            while (queue.TryDequeue(out var pos, out var lvl))
            {
                if (visited[pos.X][pos.Y])
                    continue;
                visited[pos.X][pos.Y] = true;
                if (pos.X == n - 1 && pos.X == pos.Y)
                    return lvl;
                if (pos.X > 0 && !visited[pos.X - 1][pos.Y])
                    queue.Enqueue((pos.X - 1, pos.Y), Math.Max(grid[pos.X - 1][pos.Y], lvl));
                if (pos.X < n - 1 && !visited[pos.X + 1][pos.Y])
                    queue.Enqueue((pos.X + 1, pos.Y), Math.Max(grid[pos.X + 1][pos.Y], lvl));
                if (pos.Y > 0 && !visited[pos.X][pos.Y - 1])
                    queue.Enqueue((pos.X, pos.Y - 1), Math.Max(grid[pos.X][pos.Y - 1], lvl));
                if (pos.Y < n - 1 && !visited[pos.X][pos.Y + 1])
                    queue.Enqueue((pos.X, pos.Y + 1), Math.Max(grid[pos.X][pos.Y + 1], lvl));
            }

            return 0;
        }
    }
}
