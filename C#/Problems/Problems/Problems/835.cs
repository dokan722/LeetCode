using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _835 : IProblem
    {
        public bool Test()
        {
            var img1 = new[] { new[] { 1, 1, 0 }, new[] { 0, 1, 0 }, new[] { 0, 1, 0 } };
            var img2 = new[] { new[] { 0, 0, 0 }, new[] { 0, 1, 1 }, new[] { 0, 0, 1 } };

            var expected = 3;

            var result = LargestOverlap(img1, img2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            var n = img1.Length;
            var ss = 2 * n - 1;
            var result = new int[ss][];
            for (int i = 0; i < ss; ++i)
                result[i] = new int[ss];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (img2[i][j] == 0)
                        continue;
                    for (int k = 0; k < ss; ++k)
                    {
                        for (int l = 0; l < ss; ++l)
                        {
                            var x = (i + k - n + 1);
                            var y = (j + l - n + 1);
                            if (x >= 0 && x < n && y >= 0 && y < n && img1[x][y] == 1)
                                result[k][l]++;
                        }
                    }
                }
            }

            var best = 0;
            for (int i = 0; i < ss; ++i)
            {
                for (int j = 0; j < ss; ++j)
                    best = Math.Max(best, result[i][j]);
            }

            return best;
        }
    }
}
