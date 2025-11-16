using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1975 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { 1, -1 }, new[] { -1, 1 } };

            var expected = 4;

            var result = MaxMatrixSum(matrix);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaxMatrixSum(int[][] matrix)
        {
            var min = int.MaxValue;
            long sum = 0;
            var even = true;
            var n = matrix.Length;
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    if (matrix[i][j] < 0)
                        even = !even;
                    var num = Math.Abs(matrix[i][j]);
                    min = Math.Min(min, num);
                    sum += num;
                }
            }

            return sum - (even ? 0 : 2 * min);
        }
    }
}
