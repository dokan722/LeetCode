using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _463 : IProblem
    {
        public bool Test()
        {
            var grid = new int[][] {new int[] {0, 1, 0, 0}, new int[] {1, 1, 1, 0}, new int[] {0, 1, 0, 0}, new int[] {1, 1, 0, 0}};

            var expected = 16;

            var result = IslandPerimeter(grid);

            return expected == result;
        }

        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                    result += CheckCell(i, j, grid);
            }

            return result;
        }

        int CheckCell(int i, int j, int[][] grid)
        {
            if (grid[i][j] == 0)
                return 0;
            var edges = 0;
            if (i == 0 || grid[i - 1][j] == 0)
                edges++;
            if (i == grid.Length - 1 || grid[i + 1][j] == 0)
                edges++;
            if (j == 0 || grid[i][j - 1] == 0)
                edges++;
            if (j == grid[0].Length - 1 || grid[i][j + 1] == 0)
                edges++;
            return edges;
        }
    }
}
