using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1970 : IProblem
    {
        public bool Test()
        {
            var row = 3;
            var col = 3;
            var cells = new[] { new[] {1, 2}, new[] {2, 1}, new[] {3, 3}, new[] {2, 2}, new[] {1, 1}, new[] {1, 3}, new[] {2, 3}, new[] {3, 2}, new[] {3, 1} };

            var expected = 3;

            var result = LatestDayToCross(row, col, cells);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LatestDayToCross(int row, int col, int[][] cells)
        {
            var left = col - 1;
            var right = row * col - 1;
            var dirs = new List<int[]> { new[] { 1, 0 }, new[] { 0, 1 }, new[] { -1, 0 }, new[] { 0, -1 } };
            while (left < right)
            {
                var can = false;
                var mid = (left + right + 1) / 2;
                var grid = new bool[row][];
                for (int i = 0; i < row; ++i)
                    grid[i] = new bool[col];
                for (int i = 0; i < mid; ++i)
                    grid[cells[i][0] - 1][cells[i][1] - 1] = true;

                var toVisit = new Stack<(int X, int Y)>();
                for (int i = 0; i < col; ++i)
                    if (!grid[0][i])
                        toVisit.Push((0, i));
                while (toVisit.TryPop(out var next))
                {
                    if (next.X < 0 || next.Y < 0 || next.Y >= col || grid[next.X][next.Y])
                        continue;
                    if (next.X == row - 1)
                    {
                        can = true;
                        break;
                    }

                    grid[next.X][next.Y] = true;
                    foreach (var dir in dirs)
                    {
                        toVisit.Push((next.X + dir[0], next.Y + dir[1]));
                    }
                }
                if (can)
                    left = mid;
                else
                    right = mid - 1;
            }

            return left;
        }
    }
}
