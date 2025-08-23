using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3197 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 1 } };

            var expected = 5;

            var result = MinimumSum(grid);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumSum(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = int.MaxValue;
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 0; j < m - 1; ++j)
                {
                    result = Math.Min(result, MinimumArea(grid, 0, i, 0, j) + MinimumArea(grid, 0, i, j + 1, m - 1) + MinimumArea(grid, i + 1, n - 1, 0, m - 1));
                    result = Math.Min(result, MinimumArea(grid, 0, i, j + 1, m - 1) + MinimumArea(grid, i + 1, n - 1, j + 1, m - 1) + MinimumArea(grid, 0, n - 1, 0, j));
                    result = Math.Min(result, MinimumArea(grid, i + 1, n - 1, j + 1, m - 1) + MinimumArea(grid, i + 1, n - 1, 0, j) + MinimumArea(grid, 0, i, 0, m - 1));
                    result = Math.Min(result, MinimumArea(grid, i + 1, n - 1, 0, j) + MinimumArea(grid, 0, i, 0, j) + MinimumArea(grid, 0, n - 1, j + 1, m - 1));
                }
            }

            for (int i = 0; i < n - 2; ++i)
            {
                for (int j = i + 1; j < n - 1; ++j)
                {
                    result = Math.Min(result, MinimumArea(grid, 0, i, 0, m - 1) + MinimumArea(grid, i + 1, j, 0, m - 1) + MinimumArea(grid, j + 1, n - 1, 0, m - 1));
                }
            }

            for (int i = 0; i < m - 2; ++i)
            {
                for (int j = i + 1; j < m - 1; ++j)
                {
                    result = Math.Min(result, MinimumArea(grid, 0, n - 1, 0, i) + MinimumArea(grid, 0, n - 1, i + 1, j) + MinimumArea(grid, 0, n - 1, j + 1, m - 1));
                }
            }


            return result;
        }

        private int MinimumArea(int[][] grid, int topB, int botB, int leftB, int rightB)
        {
            var top = 0;
            var found = false;
            for (int i = topB; i <= botB; ++i)
            {
                for (int j = leftB; j <= rightB; ++j)
                    if (grid[i][j] == 1)
                    {
                        top = i;
                        found = true;
                        break;
                    }
                if (found)
                    break;
            }

            if (!found)
                return 2137;
            var bot = 0;
            found = false;
            for (int i = botB; i >= topB; --i)
            {
                for (int j = leftB; j <= rightB; ++j)
                    if (grid[i][j] == 1)
                    {
                        bot = i;
                        found = true;
                        break;
                    }
                if (found)
                    break;
            }
            var left = 0;
            found = false;
            for (int i = leftB; i <= rightB; ++i)
            {
                for (int j = topB; j <= botB; ++j)
                    if (grid[j][i] == 1)
                    {
                        left = i;
                        found = true;
                        break;
                    }
                if (found)
                    break;
            }
            var right = 0;
            found = false;
            for (int i = rightB; i >= leftB; --i)
            {
                for (int j = topB; j <= botB; ++j)
                    if (grid[j][i] == 1)
                    {
                        right = i;
                        found = true;
                        break;
                    }
                if (found)
                    break;
            }

            return (right - left + 1) * (bot - top + 1);
        }
    }
}
