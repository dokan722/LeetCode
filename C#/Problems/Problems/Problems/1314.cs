using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1314 : IProblem
    {
        public bool Test()
        {
            var mat = new[] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            var k = 1;

            var expected = new[] { new[] { 12, 21, 16 }, new[] { 27, 45, 33 }, new[] { 24, 39, 28 } };

            var result = MatrixBlockSum(mat, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] MatrixBlockSum(int[][] mat, int k)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var pref = new int[n][];
            var result = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                pref[i] = new int[m];
                result[i] = new int[m];
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var left = i > 0 ? pref[i - 1][j] : 0;
                    var up = j > 0 ? pref[i][j - 1] : 0;
                    var ul = i > 0 && j > 0 ? pref[i - 1][j - 1] : 0;
                    pref[i][j] = mat[i][j] + left + up - ul;
                }
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    var t = i - k - 1;
                    var b = Math.Min(n - 1, i + k);
                    var l = j - k - 1;
                    var r = Math.Min(m - 1, j + k);
                    var total = pref[b][r];
                    var left = l >= 0 ? pref[b][l] : 0;
                    var up = t >= 0 ? pref[t][r] : 0;
                    var ul = l >= 0 && t >= 0 ? pref[t][l] : 0;
                    result[i][j] = total - left - up + ul;
                }
            }

            return result;
        }
    }
}
