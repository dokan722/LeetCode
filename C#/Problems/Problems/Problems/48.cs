using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _48 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };

            var expected = new[] { new[] { 7, 4, 1 }, new[] { 8, 5, 2 }, new[] { 9, 6, 3 } };

            Rotate(matrix);

            Utils.Print2DArray(matrix);

            return Utils.Compare2DArrays(expected, matrix);
        }

        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;
            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n - 1 - i; j++)
                {
                    var tmp = matrix[i][j];
                    matrix[i][j] = matrix[n - 1 - j][i];
                    matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j];
                    matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i];
                    matrix[j][n - 1 - i] = tmp;
                }
            }
        }
    }

}
