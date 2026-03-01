using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _240 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] {new[] {1, 4, 7, 11, 15}, new[] {2, 5, 8, 12, 19}, new[] {3, 6, 9, 16, 22}, new[] {10, 13, 14, 17, 24}, new[] {18, 21, 23, 26, 30}};
            var target = 5;

            var expected = true;

            var result = SearchMatrix(matrix, target);

            return result == expected;
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var row = 0;
            var column = m - 1;
            while (row < n && column >= 0)
            {
                if (matrix[row][column] == target)
                    return true;
                if (matrix[row][column] > target)
                    column--;
                else
                    row++;
            }

            return false;
        }
    }
}
