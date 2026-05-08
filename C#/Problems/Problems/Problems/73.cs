using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _73 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { 1, 1, 1 }, new[] { 1, 0, 1 }, new[] { 1, 1, 1 } };

            var expected = new[] { new[] { 1, 0, 1 }, new[] { 0, 0, 0 }, new[] { 1, 0, 1 } };

            SetZeroes(matrix);

            Utils.Print2DArray(matrix);

            return Utils.Compare2DArrays(matrix, expected);
        }

        public void SetZeroes(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var rows = new bool[n];
            var cols = new bool[m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (rows[i] || cols[j])
                        matrix[i][j] = 0;
                }
            }
        }
    }
}
