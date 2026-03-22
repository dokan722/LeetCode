using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1886 : IProblem
    {
        public bool Test()
        {
            var mat = new[] {new[] {0, 1}, new[] {1, 0}};
            var target = new[] { new[] { 1, 0 }, new[] { 0, 1 } };

            var expected = true;

            var result = FindRotation(mat, target);

            return result == expected;
        }

        public bool FindRotation(int[][] mat, int[][] target)
        {
            var n = mat.Length;
            var poss = 0b1111;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (mat[i][j] != target[i][j])
                        poss &= 0b0111;
                    if (mat[j][n - 1 - i] != target[i][j])
                        poss &= 0b1011;
                    if (mat[n - 1 - i][n - 1 - j] != target[i][j])
                        poss &= 0b1101;
                    if (mat[n - 1 - j][i] != target[i][j])
                        poss &= 0b1110;
                    if (poss == 0)
                        return false;
                }
            }

            return true;
        }
    }
}
