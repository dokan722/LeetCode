using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1727 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,0,1,1},new[] {0,1,1,0,1,1,1,1,0,1,1,0,0,1,0,1,1,1,1,0,1,1,1,1,1,1}};

            var expected = 34;

            var result = LargestSubmatrix(matrix);

            Console.WriteLine(result);

            return result == expected;
        }
        public int LargestSubmatrix(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var heights = new int[m];
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i != 0)
                    {
                        heights[j] = matrix[i][j] != 0 ? heights[j] + 1 : 0;
                    }
                    else
                        heights[j] = matrix[i][j];
                }

                var sorted = heights.ToArray();
                Array.Sort(sorted);
                for (int j = 1; j <= m; ++j)
                    result = Math.Max(result, j * sorted[m - j]);
            }

            return result;
        }
    }
}
