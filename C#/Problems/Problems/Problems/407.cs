using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _407 : IProblem
    {
        public bool Test()
        {
            var heightMap = new[] {new[] {1, 4, 3, 1, 3, 2}, new[] {3, 2, 1, 3, 2, 4}, new[] {2, 3, 3, 2, 3, 1}};

            var expected = 4;

            var result = TrapRainWater(heightMap);

            Console.WriteLine(result);

            return expected == result;
        }

        public int TrapRainWater(int[][] heightMap)
        {
            var n = heightMap.Length;
            var m = heightMap[0].Length;
            var visited = new bool[n][];
            for (int i = 0; i < n; i++)
                visited[i] = new bool[m];
            var boundry = new PriorityQueue<(int X, int Y), int>();
            for (int i = 0; i < n; i++)
            {
                boundry.Enqueue((i, 0), heightMap[i][0]);
                visited[i][0] = true;
                boundry.Enqueue((i, m - 1), heightMap[i][m - 1]);
                visited[i][m - 1] = true;
            }
            for (int i = 1; i < m - 1; i++)
            {
                boundry.Enqueue((0, i), heightMap[0][i]);
                visited[0][i] = true;
                boundry.Enqueue((n - 1, i), heightMap[n - 1][i]);
                visited[n - 1][i] = true;
            }

            var result = 0;
            while (boundry.TryDequeue(out var pos, out int height))
            {
                if (pos.X > 0 && !visited[pos.X - 1][pos.Y])
                {
                    var newWater = Math.Max(0, height - heightMap[pos.X - 1][pos.Y]);
                    result += newWater;
                    boundry.Enqueue((pos.X - 1, pos.Y), heightMap[pos.X - 1][pos.Y] + newWater);
                    visited[pos.X - 1][pos.Y] = true;
                }
                if (pos.X < n - 1 && !visited[pos.X + 1][pos.Y])
                {
                    var newWater = Math.Max(0, height - heightMap[pos.X + 1][pos.Y]);
                    result += newWater;
                    boundry.Enqueue((pos.X + 1, pos.Y), heightMap[pos.X + 1][pos.Y] + newWater);
                    visited[pos.X + 1][pos.Y] = true;
                }
                if (pos.Y > 0 && !visited[pos.X][pos.Y - 1])
                {
                    var newWater = Math.Max(0, height - heightMap[pos.X][pos.Y - 1]);
                    result += newWater;
                    boundry.Enqueue((pos.X, pos.Y - 1), heightMap[pos.X][pos.Y - 1] + newWater);
                    visited[pos.X][pos.Y - 1] = true;
                }
                if (pos.Y < m - 1 && !visited[pos.X][pos.Y + 1])
                {
                    var newWater = Math.Max(0, height - heightMap[pos.X][pos.Y + 1]);
                    result += newWater;
                    boundry.Enqueue((pos.X, pos.Y + 1), heightMap[pos.X][pos.Y + 1] + newWater);
                    visited[pos.X][pos.Y + 1] = true;
                }
            }

            return result;
        }
    }
}
