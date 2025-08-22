using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3195 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 1, 0 }, new[] { 1, 0, 1 } };

            var expected = 6;

            var result = MinimumArea(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumArea(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var top = 0;
            var found = false;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    if (grid[i][j] == 1)
                    {
                        top = i;
                        found = true;
                        break;
                    }
                if (found)
                    break;
            }
            var bot = 0;
            found = false;
            for (int i = n - 1; i >= 0; --i)
            {
                for (int j = 0; j < m; ++j)
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
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
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
            for (int i = m - 1; i >= 0; --i)
            {
                for (int j = 0; j < n; ++j)
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
