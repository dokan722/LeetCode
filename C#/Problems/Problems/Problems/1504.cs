using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1504 : IProblem
    {
        public bool Test()
        {
            var mat = new[] { new[] { 1, 0, 1 }, new[] { 1, 1, 0 }, new[] { 1, 1, 0 } };

            var expected = 13;

            var result = NumSubmat(mat);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumSubmat(int[][] mat)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var columns = new int[m];

            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var rectangles = new int[m];
                var prevColumns = new Stack<int>();
                for (int j = 0; j < m; ++j)
                {
                    columns[j] = mat[i][j] == 0 ? 0 : columns[j] + 1;
                    while (prevColumns.Count > 0 && columns[prevColumns.Peek()] >= columns[j])
                        prevColumns.Pop();
                    if (prevColumns.Count > 0)
                    {
                        var smaller = prevColumns.Peek();
                        rectangles[j] = rectangles[smaller] + columns[j] * (j - smaller);
                    }
                    else
                        rectangles[j] = (j + 1) * columns[j];
                    prevColumns.Push(j);
                    result += rectangles[j];
                }
            }

            return result;
        }
    }
}
