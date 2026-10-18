using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _566 : IProblem
    {
        public bool Test()
        {
            var mat = new[] {new[] {1, 2}, new[] {3, 4}};
            var r = 1;
            var c = 4;

            var expected = new[] { new[] { 1, 2, 3, 4 } };

            var result = MatrixReshape(mat, r, c);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            if (r * c != n * m || (r == n && m == c))
                return mat;
            var result = new int[r][];
            for (int i = 0; i < r; ++i)
            {
                result[i] = new int[c];
                for (int j = 0; j < c; ++j)
                {
                    var pos = i * c + j;
                    result[i][j] = mat[pos / m][pos % m];
                }
            }

            return result;
        }
    }
}
