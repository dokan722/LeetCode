using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2658 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 2, 1, 0 }, new[] { 4, 0, 0, 3 }, new[] { 1, 0, 0, 4 }, new[] { 0, 3, 2, 0 } };

            var expected = 7;

            var result = FindMaxFish(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindMaxFish(int[][] grid)
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
                    result = Math.Max(result, Dfs(i, j, visited, grid));
            }

            return result;
        }

        private int Dfs(int x, int y, bool[][] visited, int[][] grid)
        {
            if (x < 0 || x >= visited.Length || y < 0 || y >= visited[0].Length || visited[x][y] || grid[x][y] == 0)
                return 0;
            visited[x][y] = true;
            return grid[x][y] + Dfs(x - 1, y, visited, grid) + Dfs(x, y - 1, visited, grid) + Dfs(x + 1, y, visited, grid) + Dfs(x, y + 1, visited, grid);
        }
    }
}
