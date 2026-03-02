using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1536 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 0, 0, 1 }, new[] { 1, 1, 0 }, new[] { 1, 0, 0 } };

            var expected = 3;

            var result = MinSwaps(grid);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSwaps(int[][] grid)
        {
            var n = grid.Length;
            var lens = new int[n];
            for (int i = 0; i < n; ++i)
            {
                if (grid[i][n - 1] == 1)
                    lens[i] = 0;
                else
                    lens[i] = n;
                for (int j = n - 1; j >= 0; --j)
                {
                    if (grid[i][j] == 1)
                    {
                        lens[i] = n - j;
                        break;
                    }
                }
            }


            var result = 0;
            for (int i = n; i > 0; --i)
            {
                var curr = n - i;
                var j = curr;
                while (j < n && lens[j] < i)
                    j++;
                if (j < n)
                {
                    for (int k = j; k > curr; --k)
                        (lens[k - 1], lens[k]) = (lens[k], lens[k - 1]);
                    result += j - curr;
                }
                else
                    return -1;
            }

            return result;
        }
    }
}
