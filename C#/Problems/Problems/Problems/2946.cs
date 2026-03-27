using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2946 : IProblem
    {
        public bool Test()
        {
            var mat = new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
            var k = 4;

            var expected = false;

            var result = AreSimilar(mat, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool AreSimilar(int[][] mat, int k)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            if (k == m || k == 0)
                return true;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i % 2 == 0)
                    {
                        if (mat[i][j] != mat[i][((j - k) % m + m) % m])
                            return false;
                    }
                    else
                    {
                        if (mat[i][j] != mat[i][(j + k) % m])
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
