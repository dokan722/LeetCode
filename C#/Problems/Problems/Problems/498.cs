using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _498 : IProblem
    {
        public bool Test()
        {
            var mat = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};

            var expected = new[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 };

            var result = FindDiagonalOrder(mat);

            return result.SequenceEqual(expected);
        }

        public int[] FindDiagonalOrder(int[][] mat)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var cap = Math.Max(n, m);  
            var result = new List<int>();

            var x = 0;
            var y = 0;
            for (int i = 0; i < 2 * cap - 1; ++i)
            {
                if (i % 2 == 1)
                {
                    y = Math.Min(i, cap -1);
                    x = Math.Max(0, i - cap + 1);
                    while (x < cap && y >= 0)
                    {
                        if (x < n && y < m)
                            result.Add(mat[x][y]);
                        x++;
                        y--;
                    }
                }
                else
                {
                    x = Math.Min(i, cap - 1);
                    y = Math.Max(0, i - cap + 1);
                    while (y < cap && x >= 0)
                    {
                        if (x < n && y < m)
                            result.Add(mat[x][y]);
                        y++;
                        x--;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
