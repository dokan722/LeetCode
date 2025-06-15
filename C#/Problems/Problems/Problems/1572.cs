using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1572 : IProblem
    {
        public bool Test()
        {
            var nums = new int[][] { new[] { 1, 2, 3 },  new[] { 4, 5, 6 }, new[] {7, 8, 9} };

            var expected = 25;

            var result = DiagonalSum(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int DiagonalSum(int[][] mat)
        {
            var size = mat.Length;
            var sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += mat[i][i];
                sum += mat[i][size - i - 1];
            }

            if (size % 2 == 1)
                sum -= mat[size / 2][size / 2];

            return sum;
        }
    }
}
