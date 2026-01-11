using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _85 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { '1', '0', '1', '0', '0' }, new[] { '1', '0', '1', '1', '1' }, new[] { '1', '1', '1', '1', '1' }, new[] { '1', '0', '0', '1', '0' } };

            var expected = 6;

            var result = MaximalRectangle(matrix);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximalRectangle(char[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var h = new int[m];

            var result = 0;
            var stack = new Stack<int>();
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (matrix[i][j] == '1')
                        h[j]++;
                    else
                        h[j] = 0;

                    while (stack.Count > 0 && h[stack.Peek()] > h[j])
                    {
                        var top = stack.Pop();
                        var l = stack.Count == 0 ? j : j - stack.Peek() - 1;
                        result = Math.Max(result, l * h[top]);
                    }
                    stack.Push(j);
                }

                while (stack.Count > 0)
                {
                    var top = stack.Pop();
                    var l = stack.Count == 0 ? m : m - 1 - stack.Peek();
                    result = Math.Max(result, l * h[top]);
                }
            }

            return result;
        }
    }
}